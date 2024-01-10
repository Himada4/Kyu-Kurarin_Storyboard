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
    public class Stare : StoryboardObjectGenerator
    {
        [Configurable]
        public bool stare = true;
        public override void Generate()
        {

            var layer = GetLayer("stare");

            var sprites = new List<OsbSprite>();

            sprites.Add(layer.CreateSprite("sb/stare/s1.png"));
            sprites.Add(layer.CreateSprite("sb/stare/s2.png"));
            sprites.Add(layer.CreateSprite("sb/stare/s3.png"));
            sprites.Add(layer.CreateSprite("sb/stare/s4.png"));

            var nsprites = new List<OsbSprite>();
            nsprites.Add(layer.CreateSprite("sb/stare/s5.png"));
            nsprites.Add(layer.CreateSprite("sb/stare/s6.png"));
            nsprites.Add(layer.CreateSprite("sb/stare/s7.png"));


            if(stare){
                
                sprites[0].Scale(39272, 46908, 0.7, 0.7);
                sprites[0].MoveY(39272, 260);

                sprites[1].Scale(46908, 47112, 0.7, 0.7);
                sprites[1].MoveY(46908, 260);

                sprites[2].Scale(47112, 47317, 0.7, 0.7);
                sprites[2].MoveY(47112, 260);

                sprites[3].Scale(47317, 47862, 0.7, 0.7);
                sprites[3].MoveY(47317, 260);
            }else{

                nsprites[2].Scale(171680, 179726, 0.7, 0.7);
                nsprites[2].MoveY(171680, 260);

                nsprites[1].Scale(171407, 171680, 0.7, 0.7);
                nsprites[1].MoveY(171407, 260);

                nsprites[0].Scale(170998, 171407, 0.7, 0.7);
                nsprites[0].MoveY(170998, 260);

                

            }
		    
            
            
        }
    }
}
