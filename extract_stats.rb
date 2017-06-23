#!/usr/bin/env ruby

#
# This script extracts statistics from our JSON files
#
require 'csv'
require 'json'
require 'fileutils'

class String
  def underscore
    self.gsub(/::/, '/').
    gsub(/([A-Z]+)([A-Z][a-z])/,'\1_\2').
    gsub(/([a-z\d])([A-Z])/,'\1_\2').
    tr("-", "_").
    downcase
  end
end

# Script start
src_dir = ARGV[0]
raise 'Missing directory argument' if src_dir.nil?

out_type = ARGV[1]
raise "Out type must be 'photo' or 'runner'" unless %w(photo runner).include?(out_type)

data = []

json_files = Dir["#{src_dir}/*.json"]
json_files.each do |file|
  data << JSON.parse(File.read(file), symbolize_names: true)
end

def photo_stats(data)
  headers = %i[
    PhotoNumber
    Identifier
    TimeToMarkPhoto
    TimeToRespondToCrowded
    AverageTimeTakenPerPerson
    SumOfTimeTakenPerPerson
    TimesAskedForCrowdedness
    TimesUndoMade
    TimesAskedIfPhotoComplete
    TimesDeletedRunner
    TimesManualSaveMade
    TimesSaved
    TimesInvalidIncompleteBibTagged
    TimesInvalidIncompleteFaceTagged
    NumberOfPeopleTagged
    TaggingStep
    IsPhotoCrowded
  ]
  CSV do |csv|
    csv << headers.map(&:to_s).map(&:underscore)
    data.each_with_index do |photo, idx|
      row = [idx + 1]
      row += photo.select { |k, _| headers.include? k }.values
      csv << row
    end
  end
end

def runner_stats(data)
  headers = %i[
    PhotoIdentifier
    PersonNumber
    BibNumber
    TimeToClickBibRegions
    TimeToEnterBibNumber
    TimeToDoBaseClassifications
    TimeToDoColorClassifications
    TimeToDragAndDropFaceRegion
    TotalTimeTaken
    TimesBibClickMade
    TimesFaceDragAndDropMade
    TimesColorClassificationsShown
    TimesBaseClassificationsShown
    TimesDragAndDropMadeForBibSheet
    TimesDragAndDropFaceInInversedDirection
    TimesClickedForFaceRegion
    TimesSelectedFaceRegionOutsideArea
    TimesSelectedFaceRegionBelowBibSheet
    TimesAttemptedToShowBaseClassificationsWhenInvalid
    TimesAttemptedToShowColorClassificationsWhenInvalid
    IsRunnerBlurred
    Gender
    GenderName
    LikelihoodOfPurchase
    LikelihoodOfPurchaseName
  ]
  CSV do |csv|
    csv << headers.map(&:to_s).map(&:underscore)
    data.each do |photo|
      photo_id = photo[:Identifier]
      photo[:TaggedRunners].each_with_index do |runner, idx|
        bib_num = runner[:Bib][:BibNumber]
        row = [photo_id, idx + 1, bib_num]
        row += runner.select { |k, _| headers.include? k }.values
        csv << row
      end
    end
  end
end

photo_stats(data) if out_type == 'photo'
runner_stats(data) if out_type == 'runner'
