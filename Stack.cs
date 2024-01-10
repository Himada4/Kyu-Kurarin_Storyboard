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
    public class Stack : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("stack");

            var s1  = "sb/stack/s1.png";
            var s2  = "sb/stack/s2.png";
            var s3  = "sb/stack/s3.png";
            var s4  = "sb/stack/s4.png";
            var s5  = "sb/stack/s5.png";
            var s6  = "sb/stack/s6.png";
            var s7  = "sb/stack/s7.png";
            var s8  = "sb/stack/s8.png";
            var s9  = "sb/stack/s9.png";

            var c1 = "sb/cry stack/c1.png";
            var c2 = "sb/cry stack/c2.png";
            var c3 = "sb/cry stack/c3.png";
            var c4 = "sb/cry stack/c4.png";
            var c5 = "sb/cry stack/c5.png";
            var c6 = "sb/cry stack/c6.png";
            var c7 = "sb/cry stack/c7.png";

            var loop1 = new List<OsbSprite>(){create(layer, s1), create(layer, s1), 
            create(layer, s2), create(layer, s3), create(layer, s3), create(layer, s1), 
            create(layer, s3), create(layer, s1), create(layer, s4)};

            var loop2 = new List<OsbSprite>(){create(layer, s1), create(layer, s4), 
            create(layer, s3), create(layer, s5), create(layer, s5), create(layer, s4),
            create(layer, s2), create(layer, s1), create(layer, s3), create(layer, s1)};

            var loop3 = new List<OsbSprite>(){create(layer, s1), create(layer, s1), create(layer, s1) 
            , create(layer, s1) ,create(layer, s1), create(layer, s3), create(layer, s2), 
            create(layer, s1)};

            var still = new List<OsbSprite>(){create(layer, s6), create(layer, s7)};

            var still2 = new List<OsbSprite>(){create(layer, s8), create(layer, s9)};

            var cry1 = new List<OsbSprite>(){create(layer, c1), create(layer, c2), create(layer, c2),
            create(layer, c3), create(layer, c3), create(layer, c1), create(layer, c3), create(layer, c1), create(layer, c2)};

            var cry2 = new List<OsbSprite>(){create(layer, c1), create(layer, c1), create(layer, c3), create(layer, c1), create(layer, c4), create(layer, c1),
            create(layer, c4), create(layer, c1), create(layer, c3), create(layer, c4)};

            var still3 = new List<OsbSprite>(){create(layer, c1), create(layer, c5)};

            var cry3 = new List<OsbSprite>(){create(layer, c6), create(layer, c6),create(layer, c6),create(layer, c6),create(layer, c6),create(layer, c6),
            create(layer, c6),create(layer, c6)};

            var cry4 = new List<OsbSprite>(){create(layer, c6), create(layer, c6),create(layer, c6),create(layer, c6),create(layer, c6),create(layer, c6),
            create(layer, c6),create(layer, c6)};

            var still4 = new List<OsbSprite>(){create(layer, c6), create(layer, c7)};

            animation(47999, 1, loop1 , true);

            animation(50181, 2, loop2, true);

            animation(52363, 3, still, true);

            animation(118908, 4, loop3, true);

            animation(120817, 5, still2, true);

            animation(180817, 1, cry1, false);

            animation(182998, 2, cry2, false);

            animation(185180, 3, still3, false);

            
            
            animation2(197180, 1, cry3, true);

            animation2(199362,2, cry4, true);

            animation2(201544, 3, still4, true);
            
        }

        OsbSprite create(StoryboardLayer layer, string path){
            var sprite = layer.CreateSprite(path);

            return sprite;
        }

        void animation(int start, int type, List<OsbSprite> sprites, bool big){

            switch(type){
                case 1: 

                // 47999 48545 48681 48817 48954 49090 49363 49636 49908    50181

                var timing = new List<int>(){0, 546, 682, 818, 955, 1091, 1364, 1637, 1909};

                for(int i = 0; i < sprites.Count; i ++){
                    sprites[i].Fade(start + timing[i], 1);

                    if(big){
                        sprites[i].Scale(start + timing[i], 0.8);
                    }else{
                        sprites[i].Scale(start + timing[i], 0.6);
                        sprites[i].MoveY(start + timing[i], 190);
                    } 
                    

                    int moveMore = sprites.Count - i;

                    for(int j = 0; j < moveMore; j ++){
                        sprites[i].MoveX(OsbEasing.OutQuart, start + timing[i + j], start + timing[i + j] + 100, sprites[i].PositionAt(start + timing[i + j]).X, sprites[i].PositionAt(start + timing[i + j]).X - 50);
                    }
                    
                    // 2182

                    sprites[i].Fade(start + 2182, 0);

                    
                }

                break;

                case 2:

                // 47999 48545 48681 48817 48954 49090 49363 49636 49772 49908    50181

                var timing2 = new List<int>(){0, 546, 682, 818, 955, 1091, 1364, 1637, 1773, 1909};

                for(int i = 0; i < sprites.Count; i ++){
                    sprites[i].Fade(start + timing2[i], 1);
                    
                    if(big){
                        sprites[i].Scale(start + timing2[i], 0.8);
                    }else{
                        sprites[i].Scale(start + timing2[i], 0.6);
                        sprites[i].MoveY(start + timing2[i], 190);
                    }

                    int moveMore = sprites.Count - i;

                    for(int j = 0; j < moveMore; j ++){
                        sprites[i].MoveX(OsbEasing.OutQuart, start + timing2[i + j], start + timing2[i + j] + 100, sprites[i].PositionAt(start + timing2[i + j]).X, sprites[i].PositionAt(start + timing2[i + j]).X - 50);
                    }
                    
                    // 2182

                    sprites[i].Fade(start + 2182, 0);

                    
                }

                break;

                case 3:

                var diff = 56727 - 52363;

                var diff2 = 64090 - 56727;

                sprites[0].Fade(start, 1);
                sprites[0].Fade(start + diff, 0);

                sprites[1].Fade(start + diff, 1);
                sprites[1].Fade(start + diff + diff2, 0);
                if(big){
                    sprites[0].Scale(start, 0.85);
                    sprites[0].MoveX(OsbEasing.OutQuart, start, start + 300, 350, 290);
                    sprites[0].MoveX(start + 300, start + diff, 290, 280);

                    sprites[1].Scale(start + diff, 0.85);
                    sprites[1].MoveX(OsbEasing.OutQuart, start + diff, start + diff + 300, 350, 290);
                    sprites[1].MoveX(start + diff + 300, start + diff + diff2, 290, 280);
                }else{

                    sprites[0].Scale(start, 0.6);
                    sprites[0].MoveY(start, 190);
                    sprites[0].MoveX(OsbEasing.OutQuart, start, start + 300, 350, 290);
                    sprites[0].MoveX(start + 300, start + diff, 290, 280);

                    sprites[1].Scale(start + diff, 0.6);
                    sprites[1].MoveY(start + diff, 300);
                    sprites[1].MoveX(OsbEasing.OutQuart, start + diff, start + diff + 300, 120, 110);
                    sprites[1].MoveX(start + diff + 300, start + diff + diff2, 110, 105);
                }
                

                
                
                break;

                case 4:

                var timing3 = new List<int>(){0, 546, 682, 818, 955, 1091, 1364, 1637};

                for(int i = 0; i < sprites.Count; i ++){
                    sprites[i].Fade(start + timing3[i], 1);
                    sprites[i].Scale(start + timing3[i], 0.8);

                    int moveMore = sprites.Count - i;

                    for(int j = 0; j < moveMore; j ++){
                        sprites[i].MoveX(OsbEasing.OutQuart, start + timing3[i + j], start + timing3[i + j] + 100, sprites[i].PositionAt(start + timing3[i + j]).X, sprites[i].PositionAt(start + timing3[i + j]).X - 50);
                    }
                    
                    // 2182

                    sprites[i].Fade(start + 1909, 0);

                    
                }

                break;

                case 5:

                var diffc = 127362 - 120817;

                var difcf2 = 135817 - 127362; 

                sprites[0].Fade(start, 1);
                sprites[0].Fade(start + diffc, 0);
                sprites[0].Scale(start, 0.85);
                sprites[0].MoveX(OsbEasing.OutQuart, start, start + 300, 350, 290);
                sprites[0].MoveX(start + 300, start + diffc, 290, 280);

                sprites[1].Fade(start + diffc, 1);
                sprites[1].Fade(start + diffc + difcf2, 0);
                sprites[1].Scale(start + diffc, 0.85);
                sprites[1].MoveX(OsbEasing.OutQuart, start + diffc, start + diffc + 300, 350, 290);
                sprites[1].MoveX(start + diffc + 300, start + diffc + difcf2, 290, 280);


                break;
            }
        }

        void animation2(int start, int type, List<OsbSprite> sprites, bool big){

            switch(type){
                case 1: 

                // 47999 48545 48681 48817 48954 49090 49363 49636 49908    50181

                var timing = new List<int>(){0, 546, 682, 818, 955, 1091, 1364, 1637};

                for(int i = 0; i < sprites.Count; i ++){
                    sprites[i].Fade(start + timing[i], 1);

                    if(big){
                        sprites[i].Scale(start + timing[i], 0.65);
                        sprites[i].MoveY(start + timing[i], 240);
                    }else{
                        sprites[i].Scale(start + timing[i], 0.6);
                        sprites[i].MoveY(start + timing[i], 190);
                    } 
                    

                    int moveMore = sprites.Count - i;

                    for(int j = 0; j < moveMore; j ++){
                        sprites[i].MoveX(OsbEasing.OutQuart, start + timing[i + j], start + timing[i + j] + 100, sprites[i].PositionAt(start + timing[i + j]).X, sprites[i].PositionAt(start + timing[i + j]).X - 50);
                    }
                    
                    // 2182    200998 201271

                    sprites[i].MoveX(OsbEasing.OutQuart, 199089, 199362, sprites[i].PositionAt(199089).X, sprites[i].PositionAt(199089).X - 50);

                    sprites[i].Fade(start + 2182, 0);

                    
                }

                break;

                case 2:

                // 47999 48545 48681 48817 48954 49090 49363 49636 49772 49908    50181

                var timing2 = new List<int>(){0, 546, 682, 818, 955, 1091, 1364, 1637};

                for(int i = 0; i < sprites.Count; i ++){
                    sprites[i].Fade(start + timing2[i], 1);
                    
                    if(big){
                        sprites[i].Scale(start + timing2[i], 0.65);
                        sprites[i].MoveY(start + timing2[i], 240);
                    }else{
                        sprites[i].Scale(start + timing2[i], 0.6);
                        sprites[i].MoveY(start + timing2[i], 190);
                    }

                    int moveMore = sprites.Count - i;

                    for(int j = 0; j < moveMore; j ++){
                        sprites[i].MoveX(OsbEasing.OutQuart, start + timing2[i + j], start + timing2[i + j] + 100, sprites[i].PositionAt(start + timing2[i + j]).X, sprites[i].PositionAt(start + timing2[i + j]).X - 50);
                    }
                    
                    // 2182

                    sprites[i].MoveX(OsbEasing.OutQuart, 201271, 201544, sprites[i].PositionAt(201271).X, sprites[i].PositionAt(201271).X - 50);

                    sprites[i].Fade(start + 2182, 0);

                    
                }

                break;

                case 3:

                var diff = 56727 - 52363;

                var diff2 = 64090 - 56727;

                sprites[0].Fade(start, 1);
                sprites[0].Fade(start + diff, 0);

                sprites[1].Fade(start + diff, 1);
                sprites[1].Fade(start + diff + diff2, 0);
                if(big){
                    
                    sprites[0].Scale(start, 0.65);
                    sprites[0].MoveY(start, 240);
                    sprites[0].MoveX(OsbEasing.OutQuart, start, start + 300, 350, 290);
                    sprites[0].MoveX(start + 300, start + diff, 290, 280);

                    sprites[1].Scale(start + diff, 0.65);
                    sprites[1].MoveY(start + diff, 240);
                    sprites[1].MoveX(OsbEasing.OutQuart, start + diff, start + diff + 300, 350, 290);
                    sprites[1].MoveX(start + diff + 300, start + diff + diff2, 290, 280);
                }else{

                    sprites[0].Scale(start, 0.6);
                    sprites[0].MoveY(start, 190);
                    sprites[0].MoveX(OsbEasing.OutQuart, start, start + 300, 350, 290);
                    sprites[0].MoveX(start + 300, start + diff, 290, 280);

                    sprites[1].Scale(start + diff, 0.6);
                    sprites[1].MoveY(start + diff, 300);
                    sprites[1].MoveX(OsbEasing.OutQuart, start + diff, start + diff + 300, 120, 110);
                    sprites[1].MoveX(start + diff + 300, start + diff + diff2, 110, 105);
                }
                

                
                
                break;

                case 4:

                var timing3 = new List<int>(){0, 546, 682, 818, 955, 1091, 1364, 1637};

                for(int i = 0; i < sprites.Count; i ++){
                    sprites[i].Fade(start + timing3[i], 1);
                    sprites[i].Scale(start + timing3[i], 0.8);

                    int moveMore = sprites.Count - i;

                    for(int j = 0; j < moveMore; j ++){
                        sprites[i].MoveX(OsbEasing.OutQuart, start + timing3[i + j], start + timing3[i + j] + 100, sprites[i].PositionAt(start + timing3[i + j]).X, sprites[i].PositionAt(start + timing3[i + j]).X - 50);
                    }
                    
                    // 2182

                    sprites[i].Fade(start + 1909, 0);

                    
                }

                break;

                case 5:

                var diffc = 127362 - 120817;

                var difcf2 = 135817 - 127362; 

                sprites[0].Fade(start, 1);
                sprites[0].Fade(start + diffc, 0);
                sprites[0].Scale(start, 0.85);
                sprites[0].MoveX(OsbEasing.OutQuart, start, start + 300, 350, 290);
                sprites[0].MoveX(start + 300, start + diffc, 290, 280);

                sprites[1].Fade(start + diffc, 1);
                sprites[1].Fade(start + diffc + difcf2, 0);
                sprites[1].Scale(start + diffc, 0.85);
                sprites[1].MoveX(OsbEasing.OutQuart, start + diffc, start + diffc + 300, 350, 290);
                sprites[1].MoveX(start + diffc + 300, start + diffc + difcf2, 290, 280);


                break;
            }
        }
    }
}
