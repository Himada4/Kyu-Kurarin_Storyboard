using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class Bed : StoryboardObjectGenerator
    {
        [Configurable]

        public bool bed = true;
        public override void Generate()
        {
            var layer = GetLayer("bed");
            if(bed){
                

		    
                var s2  = layer.CreateSprite("sb/bed/b2.png", OsbOrigin.Centre);
                var s1  = layer.CreateSprite("sb/bed/b1.png", OsbOrigin.Centre);

                s1.Fade(81817, 98959 - 2000, 1, 0);
                s1.Scale(81817, 0.7);

                s2.Fade(81817, 1);

                s2.Fade(98959, 0);

                s2.Scale(81817, 0.7);

                s2.MoveY(81817, 330);
                s1.MoveY(81817, 330);
            }else{
                
                var s2  = layer.CreateSprite("sb/bed/b2.png", OsbOrigin.Centre);
                var s1  = layer.CreateSprite("sb/bed/b1.png", OsbOrigin.Centre);
                var s3  = layer.CreateSprite("sb/bed/b3.png", OsbOrigin.Centre);
                var s4  = layer.CreateSprite("sb/bed/b4.png", OsbOrigin.Centre);
                var s5  = layer.CreateSprite("sb/bed/b5.png", OsbOrigin.Centre);

                s1.Fade(136089, 152998 - 2000, 1, 0);
                s1.Scale(136089, 0.7);

                s2.Fade(136089, 1);

                s2.Fade(152998, 0);

                s2.Scale(136089, 0.7);

                s2.MoveY(136089, 330);
                s1.MoveY(136089, 330);

                s3.Fade(153544, 1);
                s3.Fade(160635, 0);
                s3.Scale(153544, 0.7);
                s3.MoveY(153544, 300);

                s4.Fade(160635, 1);
                s4.Fade(161998, 0);
                s4.MoveX(160635, 100);
                s4.Scale(160635, 00.7);

                s5.Fade(162271, 1);
                s5.Fade(169907, 0);
                s5.Scale(162271, 0.7);
                s5.MoveY(162271, 300);
                s5.MoveX(162271, 400);


            }
            
            
        }
    }
}
