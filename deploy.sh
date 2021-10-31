#! /usr/bin/env bash

src="docs"
dst=pi@raspberrypi.local
dir=/var/www/games.sslees.com/ld49

eval $(ssh-agent) &> /dev/null
ssh-add -q
ssh $dst "cd $dir; rm -rf Build TemplateData index.html"
scp -qr $src/* $dst:$dir
ssh $dst "cd $dir; cp sample_build_htaccess Build/.htaccess; chmod -R a+rX Build TemplateData index.html"
killall ssh-agent
