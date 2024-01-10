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
    public class Clock : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("clock");

            var sprites = new List<OsbSprite>();

            sprites.Add(layer.CreateSprite("sb/clock/c1.png"));
            sprites.Add(layer.CreateSprite("sb/clock/c2.png"));
            sprites.Add(layer.CreateSprite("sb/clock/c3.png"));
            sprites.Add(layer.CreateSprite("sb/clock/c4.png"));


            //2181 clock appear
            //3817 touch
            //4090 dissapear

            
            animation(2181, sprites);

            //break

            animation(64363, sprites);

            animation(66545, sprites);

            animation(68727, sprites);

            animation(70908, sprites);

            animation(73090, sprites);

            animation(75272, sprites);

            sprites[0].Fade(77454, 1);

            sprites[0].Fade(81545, 0);

            //sprites[0].Fade(213544, 1);

            //sprites[0].Fade(AudioDuration, 0);

            ImLazyanimation(213544, sprites);
            


            
            
        }

        private void animation(int start, List<OsbSprite> sprites){

            var touch = 3817 - 2181;

            var dissapear = 4227 - 4090;

            var frame = 1158 - 1090; 

            var timing = new List<int>(){start, start + touch, start + touch + frame, start + touch + 2*frame};

            
            for(int i = 0; i < timing.Count; i ++){
                
                if(i == timing.Count-1){
                    sprites[i].Fade(timing[i], 1);
                    sprites[i].Scale(timing[i], timing[i] + dissapear, 0.45, 0.45);
                    sprites[i].Fade(timing[i] + dissapear, 0);
                }else{
                    sprites[i].Scale(timing[i], timing[i+1], 0.45, 0.45);
                    sprites[i].Fade(timing[i], 1);
                    sprites[i].Fade(timing[i+1], 0);
                }
                    
            }

        }

        private void ImLazyanimation(int start, List<OsbSprite> sprites){

            var touch = 0;

            var dissapear = 4227 - 4090 + 200;

            var frame = 1158 - 1090; 

            var timing = new List<int>(){start, start + touch, start + touch + frame, start + touch + 2*frame};

            
            for(int i = 0; i < timing.Count; i ++){
                
                if(i == timing.Count-1){
                    sprites[i].Fade(timing[i], 1);
                    sprites[i].Scale(timing[i], timing[i] + dissapear, 0.45, 0.45);
                    sprites[i].Fade(timing[i] + dissapear, 0);
                }else{
                    sprites[i].Scale(timing[i], timing[i+1], 0.45, 0.45);
                    sprites[i].Fade(timing[i], 1);
                    sprites[i].Fade(timing[i+1], 0);
                }
                    
            }

        }
    }
}
