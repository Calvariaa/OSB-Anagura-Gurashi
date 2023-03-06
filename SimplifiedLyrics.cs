using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Subtitles;
using System.Drawing;
using System;
using System.IO;

namespace StorybrewScripts
{
    public class SimplifiedLyrics : StoryboardObjectGenerator
    {
        [Configurable]
        public string fontName = "FOT-LyraStd-DB.otf";

        [Configurable]
        public float opacity = 1f;
        
        [Configurable]
        public int fontScale = 30;

        [Configurable]
        public float spriteScale = 1f;

        [Configurable]
        public float fadeStartDelay = 622;

        [Configurable]
        public float fadeEndDelay = 622;

        [Configurable]
        public FontStyle fontStyle = FontStyle.Regular;

        [Configurable]
        public bool enableColor = false;

        [Configurable]
        public Color4 textColor = Color4.IndianRed;

        [Configurable]
        public bool enableGlow = false;

        [Configurable]
        public int glowRadius = 30;

        [Configurable]
        public Color4 glowColor = Color4.White;

        [Configurable]
        public int outlineThickness = 0;

        [Configurable]
        public Color4 outlineColor = Color4.Black;

        [Configurable]
        public int shadowThickness = 0;

        [Configurable]
        public Color4 shadowColor = Color4.Black;

        private FontGenerator font;

        public override void Generate()
        {
            font = FontGenerator("sb/lyrics");
            // CreateText(startTime, endTime, position, origin, text) sentence
            // CreateLyricsText(startTime, endTime, position, origin, text) 

            CreateLyricsText(2660, 17669, new Vector2(320, 160), OsbOrigin.Centre, "せまいせまいあなぼこで");
            CreateLyricsText(7591, 17669, new Vector2(380, 200), OsbOrigin.Centre, "夢を見せあうぼくたちは");
            CreateLyricsText(11107, 17669, new Vector2(320, 260), OsbOrigin.Centre, "あの世もこの世もいられない");
            CreateLyricsText(14857, 17669, new Vector2(380, 300), OsbOrigin.Centre, "あの世もこの世もいられない");

            CreateLyricsText(18138, 30322, new Vector2(260, 320), OsbOrigin.Centre, "ああ神様　子どもの神様");
            CreateLyricsText(22357, 30322, new Vector2(260, 360), OsbOrigin.Centre, "ぼくらはあなたの遊んだ砂場の中で");
            CreateLyricsText(27982, 30322, new Vector2(260, 400), OsbOrigin.Centre, "すり傷だらけです");

            CreateLyricsText(69340, 79288, new Vector2(260, 120), OsbOrigin.Centre, "踊るよ 回るよ　僕らの踊りはおかしな踊り");
            CreateLyricsText(74625, 79288, new Vector2(360, 180), OsbOrigin.Centre, "踊ったつもりで　笑ったつもりで");
            CreateLyricsText(77112, 79288, new Vector2(400, 240), OsbOrigin.Centre, "倒れたつもりで　叫んだつもり");
            
            CreateLyricsText(79599, 89237, new Vector2(320, 140), OsbOrigin.Centre, "目がふらふら　音もふにゃふにゃ");
            CreateLyricsText(82242, 89237, new Vector2(380, 180), OsbOrigin.Centre, "足もふらふら　マボロシふにゃふにゃ");
            CreateLyricsText(84573, 89237, new Vector2(320, 240), OsbOrigin.Centre, "太陽も月も　空も神さまも");
            CreateLyricsText(86905, 89237, new Vector2(380, 280), OsbOrigin.Centre, "生み出して　あなぐらぐらしは");
            
            CreateLyricsText(89548, 96801, new Vector2(380, 200), OsbOrigin.Centre, "抜け出せない　抜け出せない");
            CreateLyricsText(92035, 96801, new Vector2(340, 260), OsbOrigin.Centre, "抜け出せないから　抜け出さない");
            CreateLyricsText(94522, 96801, new Vector2(340, 320), OsbOrigin.Centre, "抜け出さないから　お目目閉じて");

            CreateLyricsText(97009, 99185, new Vector2(340, 360), OsbOrigin.Centre, "２");
            CreateLyricsText(97630, 99185, new Vector2(380, 360), OsbOrigin.Centre, "１");
            CreateLyricsText(98252, 99185, new Vector2(420, 360), OsbOrigin.Centre, "０");

            CreateLyricsText(99496, 109133, new Vector2(320, 120), OsbOrigin.Centre, "落ちて落ちて　落ちてゆこうよ");
            CreateLyricsText(101983, 109133, new Vector2(400, 180), OsbOrigin.Centre, "あなぐらぐらしの渦の中");
            CreateLyricsText(104470, 109133, new Vector2(320, 240), OsbOrigin.Centre, "落ちて落ちて　落ちてゆこうよ");
            CreateLyricsText(106957, 109133, new Vector2(400, 300), OsbOrigin.Centre, "いっしょに仲良くどこまでも");

            CreateLyricsText(109444, 121257, new Vector2(300, 100), OsbOrigin.Centre, "おんなじ　おんなじ　おんなじじゃないか");
            CreateLyricsText(112086, 121257, new Vector2(340, 160), OsbOrigin.Centre, "きみと僕とはいつまでも");
            CreateLyricsText(114418, 121257, new Vector2(320, 260), OsbOrigin.Centre, "おんなじ　おんなじ　おんなじじゃないか");
            CreateLyricsText(116905, 121257, new Vector2(360, 320), OsbOrigin.Centre, "いけない　いけない　さみしい　さみしい");
            
            CreateLyricsText(121879, 131516, new Vector2(300, 360), OsbOrigin.Centre, "落ちて落ちて　落ちてゆこうよ　ラララ･･･");
            CreateLyricsText(131827, 138978, new Vector2(260, 400), OsbOrigin.Centre, "おんなじ　おんなじ　おんなじじゃないか　ラララ･･･");

            CreateLyricsText(139288, 143952, new Vector2(320, 240), OsbOrigin.Centre, "いけない　いけない　さみしい　さみしい");
            
            CreateLyricsText(149237, 158874, new Vector2(340, 200), OsbOrigin.Centre, "なかま なかま　あなたはいかが");
            CreateLyricsText(151724, 158874, new Vector2(340, 240), OsbOrigin.Centre, "なかま なかま　ぼくらはなかま");
            CreateLyricsText(154211, 158874, new Vector2(320, 300), OsbOrigin.Centre, "あなたはなかま？合言葉？");
            CreateLyricsText(156698, 158874, new Vector2(320, 340), OsbOrigin.Centre, "あなぐらせかいの合言葉？");
            
            CreateLyricsText(159185, 173796, new Vector2(320, 140), OsbOrigin.Centre, "抜け出せない　抜け出せない");
            CreateLyricsText(161672, 173796, new Vector2(340, 180), OsbOrigin.Centre, "抜け出せないから　教えない");
            CreateLyricsText(164159, 173796, new Vector2(320, 240), OsbOrigin.Centre, "あなたはなかま？　さみしいなかま？");
            CreateLyricsText(166646, 173796, new Vector2(340, 280), OsbOrigin.Centre, "奈落に生きるなかまですか");
            
            CreateLyricsText(218874, 228822, new Vector2(340, 200), OsbOrigin.Centre, "夢をかけらを飲んでいる");
            CreateLyricsText(221672, 228822, new Vector2(400, 240), OsbOrigin.Centre, "きみの夢もまぜまぜしていて");
            CreateLyricsText(223848, 228822, new Vector2(380, 320), OsbOrigin.Centre, "あの世もこの世もいられない");
            CreateLyricsText(226335, 228822, new Vector2(440, 360), OsbOrigin.Centre, "あの世もこの世もいられない");
            
            CreateLyricsText(229133, 238459, new Vector2(320, 140), OsbOrigin.Centre, "目がふらふら 音もふにゃふにゃ");
            CreateLyricsText(231465, 238459, new Vector2(380, 180), OsbOrigin.Centre, "腕もふらふら マボロシふにゃふにゃ");
            CreateLyricsText(233744, 238459, new Vector2(320, 240), OsbOrigin.Centre, "太陽も月も空も神さまも");
            CreateLyricsText(236283, 238459, new Vector2(380, 280), OsbOrigin.Centre, "ギトギトに鮮やかで");
            
            CreateLyricsText(238770, 255247, new Vector2(340, 120), OsbOrigin.Centre, "抜け出せない　抜け出せない");
            CreateLyricsText(241257, 255558, new Vector2(380, 160), OsbOrigin.Centre, "抜け出せないから　抜け出さない");
            CreateLyricsText(243744, 255869, new Vector2(420, 220), OsbOrigin.Centre, "抜け出さないから　お目目閉じて");
            CreateLyricsText(245610, 256180, new Vector2(460, 260), OsbOrigin.Centre, "閉じて･･･");
            CreateLyricsText(251206, 256180, new Vector2(580, 260), OsbOrigin.Centre, "ルルル･･･");

            CreateLyricsText(99496 + 179067, 288200, new Vector2(320, 120), OsbOrigin.Centre, "落ちて落ちて　落ちてゆこうよ");
            CreateLyricsText(101983 + 179067, 288200, new Vector2(400, 180), OsbOrigin.Centre, "あなぐらぐらしの渦の中");
            CreateLyricsText(104470 + 179067, 288200, new Vector2(320, 240), OsbOrigin.Centre, "落ちて落ちて　落ちてゆこうよ");
            CreateLyricsText(106957 + 179067, 288200, new Vector2(400, 300), OsbOrigin.Centre, "いっしょに仲良くどこまでも");

            CreateLyricsText(288511, 298149, new Vector2(300, 100), OsbOrigin.Centre, "おんなじ　おんなじ　おんなじじゃないか");
            CreateLyricsText(291154, 298149, new Vector2(340, 160), OsbOrigin.Centre, "きみと僕とはいつまでも");
            CreateLyricsText(293485, 298149, new Vector2(320, 260), OsbOrigin.Centre, "おんなじ　おんなじ　おんなじじゃないか");
            CreateLyricsText(295972, 298149, new Vector2(360, 320), OsbOrigin.Centre, "いけない　いけない　さみしい　さみしい");
            
            CreateLyricsText(298459, 308097, new Vector2(300, 360), OsbOrigin.Centre, "落ちて落ちて　落ちてゆこうよ　ラララ･･･");
            CreateLyricsText(308408, 315558, new Vector2(260, 400), OsbOrigin.Centre, "おんなじ　おんなじ　おんなじじゃないか　ラララ･･･");

            CreateLyricsText(315869, 318045, new Vector2(320, 240), OsbOrigin.Centre, "いけない　いけない　さみしい　さみしい");
            /*
            落ちて落ちて落ちてゆこうよ
            あなぐらぐらしの渦の中
            落ちて落ちて落ちてゆこうよ
            いっしょに仲良くどこまでも


            おんなじ　おんなじ　おんなじじゃないか
            きみと僕とはいつまでも
            おんなじ　おんなじ　おんなじじゃないか
            いけない　いけない　さみしい　さみしい

            落ちて落ちて落ちてゆこうよ　ラララ･･･
            落ちて落ちて落ちてゆこうよ　ラララ･･･
            おんなじ　おんなじ　おんなじじゃないか　ラララ･･･
            おんなじ　おんなじ　おんなじじゃないか
            いけない　いけない　さみしい　さみしい*/
        }

        FontGenerator FontGenerator(string output)
        {
            var font = LoadFont(output, new FontDescription()
            {
                FontPath = fontName,
                FontSize = fontScale,
                Color = Color4.White,
                Padding = Vector2.Zero,
                FontStyle = fontStyle,
                TrimTransparency = true,
                EffectsOnly = false,
                Debug = false,
            },
            new FontGlow()
            {
                Radius = !enableGlow ? 0 : glowRadius,
                Color = glowColor,
            },
            new FontOutline()
            {
                Thickness = outlineThickness,
                Color = outlineColor,
            },
            new FontShadow()
            {
                Thickness = shadowThickness,
                Color = shadowColor,
            });

            return font;
        }

        // lyrics code
        public void CreateText(int startTime, int endTime, Vector2 position, OsbOrigin origin, string text)
        {
            var texture = font.GetTexture(text);
            var sprite = GetLayer("").CreateSprite(texture.Path, origin, position);

            sprite.Scale(startTime, 0.5f * spriteScale);
            sprite.Fade(startTime, startTime + fadeStartDelay, 0, opacity);
            sprite.Fade(endTime, endTime + fadeEndDelay, opacity, 0);
            //sprite.Additive(startTime);
            if (enableColor)
            sprite.Color(startTime, textColor);
        }
        public void CreateLyricsText(int startTime, int endTime, Vector2 position, OsbOrigin origin, string text) //, bool additive
        {
            var letterY = position.Y;
            var lineWidth = 0f;
            var lineHeight = 0f;
            int loopCount = 0;
            char[] temp = text.ToCharArray();
            foreach (var i in temp)
            {
                var texture = font.GetTexture(i.ToString());
                lineWidth += texture.BaseWidth * 0.5f * spriteScale;
                lineHeight = Math.Max(lineHeight, texture.BaseHeight * 0.5f * spriteScale);
            }

            var letterX = position.X; // - lineWidth * 0.5f 居中还是靠左
            foreach (var i in temp)
            {
                var texture = font.GetTexture(i.ToString());
                if (!texture.IsEmpty)
                {
                    var position2 = new Vector2(letterX, letterY)
                        + texture.OffsetFor(origin) * 0.5f * spriteScale;
                    var sprite = GetLayer("").CreateSprite(texture.Path, origin, position2);

                    startTime += Easing(loopCount, temp.GetLength(0));
                    endTime += Easing2(loopCount, temp.GetLength(0));  // 啊

                    sprite.Scale(startTime, 0.5f * spriteScale);
                    sprite.Fade(startTime, startTime + fadeStartDelay, 0, opacity);
                    sprite.Fade(endTime, endTime + fadeEndDelay, opacity, 0);
                    //sprite.Fade(startTime - 200, startTime, 0, 1);
                    //sprite.Fade(endTime - 200, endTime, 1, 0);
                    //if (additive) sprite.Additive(startTime - 200, endTime);

                    loopCount++;
                }
                letterX += texture.BaseWidth * 0.5f * spriteScale;
            }
            letterY += lineHeight;    
        }
        public int Easing(int p, int length)
        {
            double[] e = new double[30];
            e[0] = 0;
            for(int i=0;i<length;i++)
            {
                e[i] = (i * 8 / length) * (i * 8 / length);
            }
            return (int)e[p];
        }
        public int Easing2(int p, int length)
        {
            double[] e = new double[30];
            e[0] = 0;
            for(int i=0, j=length;i<length;i++, j--)
            {
                e[j] = (i * 6 / length) * (i * 6 / length);
            }
            return (int)e[p];
        }
    }
}