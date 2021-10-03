#! /usr/bin/env bash

src="Builds/WebGL"
dst=pi@raspberrypi.local
dir=/var/www/games.sslees.com

eval $(ssh-agent) &> /dev/null
ssh-add -q
ssh $dst "cd $dir; rm -rf Build TemplateData index.html"
scp -qr $src/* $dst:$dir
ssh $dst "cd $dir; cp sample_build_htaccess Build/.htaccess; chmod -R a+rX Build TemplateData index.html"
killall ssh-agent
