using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Subtitles;
using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;

namespace StorybrewScripts
{
    public class Credit : StoryboardObjectGenerator
    {
        [Configurable]
        public string SubtitlesPath = "lyrics.srt";

        [Configurable]
        public string FontName = "Verdana";

        [Configurable]
        public string SpritesPath = "sb/f";

        [Configurable]
        public int FontSize = 26;

        [Configurable]
        public float FontScale = 0.5f;

        [Configurable]
        public Color4 FontColor = Color4.White;

        [Configurable]
        public FontStyle FontStyle = FontStyle.Regular;

        [Configurable]
        public int GlowRadius = 0;

        [Configurable]
        public Color4 GlowColor = new Color4(255, 255, 255, 100);

        [Configurable]
        public bool AdditiveGlow = true;

        [Configurable]
        public int OutlineThickness = 3;

        [Configurable]
        public Color4 OutlineColor = new Color4(50, 50, 50, 200);

        [Configurable]
        public int ShadowThickness = 0;

        [Configurable]
        public Color4 ShadowColor = new Color4(0, 0, 0, 100);

        [Configurable]
        public Vector2 Padding = Vector2.Zero;

        [Configurable]
        public float SubtitleY = 400;

        [Configurable]
        public bool PerCharacter = true;

        [Configurable]
        public bool TrimTransparency = true;

        [Configurable]
        public bool EffectsOnly = false;

        [Configurable]
        public bool Debug = false;

        [Configurable]
        public OsbOrigin Origin = OsbOrigin.Centre;

        public override void Generate()
        {
            /*
            var dysGalLayer = GetLayer("credit");

            var map = dysGalLayer.CreateSprite("sb/c/_000.png", OsbOrigin.Centre);

            var hs = dysGalLayer.CreateSprite("sb/c/_004.png", OsbOrigin.Centre);

            var sb = dysGalLayer.CreateSprite("sb/c/_006.png", OsbOrigin.Centre);

            //var sg = dysGalLayer.CreateSprite("sb/c/_008.png", OsbOrigin.Centre);

            var top = new List<OsbSprite>(){map,hs,sb};

            
            string namePath = "";
            switch(Beatmap.Name){
                case "t":
                namePath = "sb/c/_001.png";
                break;

                case "a":
                namePath = "sb/c/_002.png";
                break;

                case "b":
                namePath = "sb/c/_003.png";
                break;
            }


            var mapper = dysGalLayer.CreateSprite(namePath, OsbOrigin.Centre);

            

            

            var cami = dysGalLayer.CreateSprite("sb/c/_005.png", OsbOrigin.Centre);

            var himada = dysGalLayer.CreateSprite("sb/c/_007.png", OsbOrigin.Centre);

            var song = dysGalLayer.CreateSprite("sb/c/_009.png", OsbOrigin.Centre);

            var btm = new List<OsbSprite>(){mapper,cami,himada,song};

            int start = 4363;

            int diff = 8727 - 4363;

            for(int i = 0; i < top.Count; i ++){
                top[i].Fade(start + diff * i, 1);
                top[i].Fade(start + diff * (i+1), 0);

                top[i].Scale(start + diff * i, 0.4);

                top[i].Move(start + diff * i, new Vector2(600,220));
            }

            for(int i = 0; i < btm.Count; i ++){
                btm[i].Fade(start + diff * i, 1);
                btm[i].Fade(start + diff * (i+1), 0);

                btm[i].Scale(start + diff * i, 0.4);

                if(i == btm.Count-1){
                    btm[i].Move(start + diff * i, new Vector2(600,240));
                }else{
                    btm[i].Move(start + diff * i, new Vector2(600,260));
                }
                
            }

            


            


            */
            //customGenerate();

            var a = GetLayer("credit");
            
            //Credit name
            var map = a.CreateSprite("sb/c/_000.png", OsbOrigin.Centre);
            var hs = a.CreateSprite("sb/c/_001.png", OsbOrigin.Centre);
            var sb = a.CreateSprite("sb/c/_002.png", OsbOrigin.Centre);


            //peeps
            var ougi = a.CreateSprite("sb/c/_003.png", OsbOrigin.Centre);
            var tsuki = a.CreateSprite("sb/c/_004.png", OsbOrigin.Centre);
            var pause = a.CreateSprite("sb/c/_005.png", OsbOrigin.Centre);
            var collab = a.CreateSprite("sb/c/_006.png", OsbOrigin.Centre);
            var seros = a.CreateSprite("sb/c/_007.png", OsbOrigin.Centre);
            var opp = a.CreateSprite("sb/c/_008.png", OsbOrigin.Centre);

            
            var Himada = a.CreateSprite("sb/c/_009.png", OsbOrigin.Centre);
            var sn = a.CreateSprite("sb/c/_00a.png", OsbOrigin.Centre);

            
            
            //0pp's Tecxpert -> 0ppInOsu
                //Anxiety -> 0ugi
                //Collab Hard -> Kyuuchie & 0ugi
                //Insane -> 0ugi
                //Pause's Extra -> Pause
                //Seros' Another -> Seros
                //Tsukinyuni's Normal -> Tsukinyuni
            
            OsbSprite hitsounder = ougi;
            OsbSprite namePath = ougi;
            switch(Beatmap.Name){
                case "0pp's Tecxpert":
                namePath = opp;
                hitsounder = opp;
                break;

                case "Anxiety":
                namePath = ougi;
                break;

                case "Collab Hard":
                namePath = collab;
                break;

                case "Insane":
                namePath = ougi;
                break;

                case "Pause's Extra":
                namePath = pause;
                break;

                case "Seros' Another":
                namePath = seros;
                break;

                case "Tsukinyuni's Normal":
                namePath = tsuki;
                break;
            }

            var mapper = namePath;

            var up = new List<OsbSprite>(){map, hs, sb};
            var down = new List<OsbSprite>(){mapper, hitsounder, Himada};

            up[0].Fade(4363,8727,1,1);
            up[0].Scale(4363,8727,0.4,0.4);
            up[0].Move(4363, new Vector2(600,220));
            up[0].Additive(4363);


            up[1].Fade(8727,13090,1,1);
            up[1].Scale(8727,13090,0.4,0.4);
            up[1].Move(8727, new Vector2(600,220));
            up[1].Additive(8727);


            up[2].Fade(13090,17454,1,1);
            up[2].Scale(13090,17454,0.4,0.4);
            up[2].Move(13090, new Vector2(600,220));
            up[2].Additive(13090);
            

///////////////////////////////


            down[0].Fade(4363,8727,1,1);
            down[0].Scale(4363,8727,0.4,0.4);
            down[0].Move(4363, new Vector2(600,260));
            down[0].Additive(4363);


            down[1].Fade(8727,13090,1,1);
            down[1].Scale(8727,13090,0.4,0.4);
            down[1].Move(8727, new Vector2(600,260));
            down[1].Additive(8727);


            down[2].Fade(13090,17454,1,1);
            down[2].Scale(13090,17454,0.4,0.4);
            down[2].Move(13090, new Vector2(600,260));
            down[2].Additive(13090);


            sn.Fade(17454,21817,1,1);
            sn.Move(17454, new Vector2(600,240));
            sn.Scale(17454,21817,0.4,0.4);
            sn.Additive(17454);
            
        }
 
        void customGenerate(){
            var font = LoadFont(SpritesPath, new FontDescription()
            {
                FontPath = FontName,
                FontSize = FontSize,
                Color = FontColor,
                Padding = Padding,
                FontStyle = FontStyle,
                TrimTransparency = TrimTransparency,
                EffectsOnly = EffectsOnly,
                Debug = Debug,
            },
            new FontGlow()
            {
                Radius = AdditiveGlow ? 0 : GlowRadius,
                Color = GlowColor,
            },
            new FontOutline()
            {
                Thickness = OutlineThickness,
                Color = OutlineColor,
            },
            new FontShadow()
            {
                Thickness = ShadowThickness,
                Color = ShadowColor,
            });

            var subtitles = LoadSubtitles(SubtitlesPath);

            if (GlowRadius > 0 && AdditiveGlow)
            {
                var glowFont = LoadFont(Path.Combine(SpritesPath, "glow"), new FontDescription()
                {
                    FontPath = FontName,
                    FontSize = FontSize,
                    Color = FontColor,
                    Padding = Padding,
                    FontStyle = FontStyle,
                    TrimTransparency = TrimTransparency,
                    EffectsOnly = true,
                    Debug = Debug,
                },
                new FontGlow()
                {
                    Radius = GlowRadius,
                    Color = GlowColor,
                });
                generateLyrics(glowFont, subtitles, "glow", true);
            }
            generateLyrics(font, subtitles, "", false);
        }

        public void generateLyrics(FontGenerator font, SubtitleSet subtitles, string layerName, bool additive)
        {
            var layer = GetLayer(layerName);
            if (PerCharacter) generatePerCharacter(font, subtitles, layer, additive);
            else generatePerLine(font, subtitles, layer, additive);
        }

        public void generatePerLine(FontGenerator font, SubtitleSet subtitles, StoryboardLayer layer, bool additive)
        {
            foreach (var line in subtitles.Lines)
            {
                var texture = font.GetTexture(line.Text);
                var position = new Vector2(320 - texture.BaseWidth * FontScale * 0.5f, SubtitleY)
                    + texture.OffsetFor(Origin) * FontScale;

                var sprite = layer.CreateSprite(texture.Path, Origin, position);
                sprite.Scale(line.StartTime, FontScale);
                sprite.Fade(line.StartTime - 200, line.StartTime, 0, 1);
                sprite.Fade(line.EndTime - 200, line.EndTime, 1, 0);
                if (additive) sprite.Additive(line.StartTime - 200, line.EndTime);
            }
        }

        public void generatePerCharacter(FontGenerator font, SubtitleSet subtitles, StoryboardLayer layer, bool additive)
        {
            foreach (var subtitleLine in subtitles.Lines)
            {
                var letterY = SubtitleY;
                foreach (var line in subtitleLine.Text.Split('\n'))
                {
                    var lineWidth = 0f;
                    var lineHeight = 0f;
                    foreach (var letter in line)
                    {
                        var texture = font.GetTexture(letter.ToString());
                        lineWidth += texture.BaseWidth * FontScale;
                        lineHeight = Math.Max(lineHeight, texture.BaseHeight * FontScale);
                    }

                    var letterX = 320 - lineWidth * 0.5f;
                    foreach (var letter in line)
                    {
                        var texture = font.GetTexture(letter.ToString());
                        if (!texture.IsEmpty)
                        {
                            var position = new Vector2(letterX, letterY)
                                + texture.OffsetFor(Origin) * FontScale;

                            var sprite = layer.CreateSprite(texture.Path, Origin, position);
                            sprite.Scale(subtitleLine.StartTime, FontScale);
                            sprite.Fade(subtitleLine.StartTime - 200, subtitleLine.StartTime, 0, 1);
                            sprite.Fade(subtitleLine.EndTime - 200, subtitleLine.EndTime, 1, 0);
                            if (additive) sprite.Additive(subtitleLine.StartTime - 200, subtitleLine.EndTime);
                        }
                        letterX += texture.BaseWidth * FontScale;
                    }
                    letterY += lineHeight;
                }
            }
        }
    }
}
