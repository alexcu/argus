#!/usr/bin/env bash

PATH_TO_ARGUS_DEPLOY="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"/bin
S3_BUCKET_NAME=dstil-argus
ARGUS_WEB_PAGE=/Volumes/my-home/public_html/argus/
PWD=$(pwd)

echo "Zipping Argus..."
cd $PATH_TO_ARGUS_DEPLOY
zip -r $ARGUS_WEB_PAGE/Argus.zip . -x "*.DS_Store" -q
cd $PWD

echo "Cleaning $S3_BUCKET_NAME..."
aws s3 rm s3://$S3_BUCKET_NAME --recursive --quiet

echo "Deploying to $S3_BUCKET_NAME..."
aws s3 cp $PATH_TO_ARGUS_DEPLOY s3://$S3_BUCKET_NAME/ --recursive --quiet --grants read=uri=http://acs.amazonaws.com/groups/global/AllUsers

echo "Done!"
