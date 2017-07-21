#!/usr/bin/env ruby

#
# This script extracts features from our JSON files
# Requires `rmagic` gem installed as well as imagemagick
#
require 'csv'
require 'json'
require 'fileutils'
require 'matrix'
require 'rmagick'

# Allow matrix to be set
class Matrix
  public :"[]=", :set_element, :set_component
end

# Script start
src_dir = ARGV[0]
raise 'Missing directory argument' if src_dir.nil?

out_dir = ARGV[1]
raise 'Missing output directory argument' if out_dir.nil?

padding = ARGV[2].nil? ? 10 : ARGV[2].to_i
puts "Padding has been set to #{padding}px"

data = []
json_files = Dir["#{src_dir}/*.json"]
json_files.each do |file|
  data << JSON.parse(File.read(file), symbolize_names: true)
end

def get_cropping_boundaries(photo_io, coords, padding)
  coords = Matrix.rows(coords.map { |s| s.split(',') }.map { |s| s.map(&:strip).map(&:to_i) })
  # Set matrix scale dependent on rows (2x2 = face, 4x2 = bib)
  scale =
    if coords.row_count == 4
      Matrix[[-1, -1], [1, -1], [1, 1], [-1, +1]]
    else
      Matrix[[-1, -1], [-1, +1]]
    end
  scaled_coords = (padding * scale) + coords
  photo_width = photo_io.columns
  photo_height = photo_io.rows
  # Prevent lvalues (col = 0) > width and rvalues (col = 1) > height and negative values
  scaled_coords.each_with_index do |e, row, col|
    if e < 0
      puts "Mapping negative scaled coordinate #{e} to 0..."
      scaled_coords[row, col] = 0
    end
    is_x = col == 0
    is_y = col == 1
    if is_x && e > photo_width
      puts "Mapping x-coordinate #{e} > photo width (#{photo_width}) to #{photo_width}..."
      scaled_coords[row, col] = photo_width
    elsif is_y && e > photo_height
      puts "Mapping y-coordinate #{e} > photo height (#{photo_height}) to #{photo_height}..."
      scaled_coords[row, col] = photo_height
    end
  end
  # Find minX, minY, maxX, and maxY
  max_x = max_y = 0
  min_x = photo_width
  min_y = photo_height
  scaled_coords.each_with_index do |e, _, col|
    is_x = col == 0
    is_y = col == 1
    # Need to do min first!
    if is_x && e < min_x
      min_x = e
    elsif is_x && e > max_x
      max_x = e
    elsif is_y && e < min_y
      min_y = e
    elsif is_y && e > max_y
      max_y = e
    end
  end
  x = min_x
  y = min_y
  width = max_x - min_x
  height = max_y - min_y
  return [x, y, width, height]
end

def extract(type, runner, photo_io, photo_id, rotation, padding, out_dir)
  bib_num = runner[:Bib][:BibNumber]
  x, y, width, height = get_cropping_boundaries(photo_io, runner[type][:PixelPoints], padding)
  cropped_img = photo_io.crop(x, y, width, height)
  # Un-rotate image
  cropped_img.rotate!(-rotation) unless rotation == 90
  # Convert
  outfile = "jpeg:#{out_dir}/#{type}_padding#{padding}_#{photo_id}\##{bib_num}.jpg"
  cropped_img.auto_orient!
  cropped_img.write(outfile) {
    self.quality = 80
  }
end

data.each_with_index do |photo, idx|
  photo_id = photo[:Identifier]
  puts "Processing #{photo_id} (#{idx + 1}/#{data.count})"
  photo_filename = "#{ARGV[0]}/#{photo_id}.jpg"
  next unless File.exists?(photo_filename)
  photo_io = Magick::Image.read(photo_filename)[0]
  # ROTATE the image as needed
  rotation = photo[:Rotation] * 90
  photo_io.rotate!(rotation) unless rotation == 90
  photo[:TaggedRunners].each do |runner|
    extract(:Bib, runner, photo_io, photo_id, rotation, padding, out_dir)
    extract(:Face, runner, photo_io, photo_id, rotation, padding, out_dir)
  end
end
