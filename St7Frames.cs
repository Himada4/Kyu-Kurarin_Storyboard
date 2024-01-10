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
    public class St7Frames : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("7frame");

            var sprites = new List<OsbSprite>();

            sprites.Add(layer.CreateSprite("sb/7frames/f1.png"));
            sprites.Add(layer.CreateSprite("sb/7frames/f2.png"));
            sprites.Add(layer.CreateSprite("sb/7frames/f3.png"));
            sprites.Add(layer.CreateSprite("sb/7frames/f4.png"));
            sprites.Add(layer.CreateSprite("sb/7frames/f5.png"));
            sprites.Add(layer.CreateSprite("sb/7frames/f6.png"));
            sprites.Add(layer.CreateSprite("sb/7frames/f7.png"));

            animation(4363, 16, sprites);
            
        }

        private void animation(int start, int loops, List<OsbSprite> sprites){
            var beat = 4636 - 4363;

            int l = 0;
            while(l < loops){
                for(int i = 0; i < sprites.Count; i ++){

                    sprites[i].Scale(start + (beat * i),0.7);
                    sprites[i].Fade(start + (beat * i), 1);
                    sprites[i].MoveY(OsbEasing.OutElastic, start + (beat * i), start + (beat * i) + 250, 00, 250);
                    sprites[i].MoveX(start + (beat * i), 350);

                    int moreMove = sprites.Count - i + 1;

                    for(int j = 0; j < moreMove; j ++){
                        sprites[i].MoveX(OsbEasing.OutBack, start + (beat * (i + j)), 
                        start + (beat * (i + j)) + 250, sprites[i].PositionAt(start + (beat * (i + j))).X,
                        sprites[i].PositionAt(start + (beat * (i + j))).X - 45);
                    }

                    if(l == loops - 1){
                        sprites[i].Fade((start + (beat * (sprites.Count + 1)))-150, 0);
                    }else{
                        sprites[i].Fade((start + (beat * (sprites.Count + 1))- 1)-150, 0);
                    }
                    
                }
                l++;
                start = start + (beat * (sprites.Count + 1));
                
            }
        }
    }
}

/*
                    sprites[i].MoveX(start, 200);
                    if(loops > 1){
                        sprites[i].MoveX(start + (beat * i), sprites[i].PositionAt(start + (beat * (sprites.Count))).X + 30);
                    }
                    
                    sprites[i].Scale(start + (beat * i),0.7);
                    sprites[i].Fade(start + (beat * i), 1);
                    sprites[i].MoveY(OsbEasing.OutElastic, start + (beat * i), start + (beat * i) + 250, -230, 250);
                    if(l == loops - 1){
                        sprites[i].Fade(start + (beat * (sprites.Count + 1)), 0);
                    }else{
                        sprites[i].Fade(start + (beat * (sprites.Count + 1))- 1, 0);
                    }
                    
                    sprites[i].MoveX(OsbEasing.OutElastic,start + (beat * (sprites.Count)),start + (beat * (sprites.Count + 1)), 
                    sprites[i].PositionAt(start + (beat * (sprites.Count))).X, sprites[i].PositionAt(start + (beat * (sprites.Count))).X - 30);

                    /*

                    for(int j = 0; j < (sprites.Count - i + 1); j ++)
                    {
                        sprites[i].MoveX(OsbEasing.OutElastic,start + (beat * j), start + (beat * j) + 250, 
                        sprites[i].PositionAt(start + (beat * (sprites.Count))).X, sprites[i].PositionAt(start + (beat * (sprites.Count))).X - 30);
                    }
                    */
