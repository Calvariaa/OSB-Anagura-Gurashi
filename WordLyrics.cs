using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using System.Collections.Generic;
using System.IO;
using StorybrewCommon.Subtitles;
using OpenTK.Graphics;
using OpenTK;

namespace StorybrewScripts
{
    public class WordLyrics : StoryboardObjectGenerator
    {
        [Configurable] public string path;
        [Configurable] public string fontName;
        [Configurable] public int fontSize;
        [Configurable] public int wordSpace = 20;
        [Configurable] public Color4 color = Color4.White;
        private FontGenerator font;
        public override void Generate()
        {
            AddDependency(ProjectPath + "/" + path);
            GetFont();
		    GenerateLyrics(LoadLyrics());    
        }
        private void GetFont()
        {
            font = LoadFont("sb/f", new FontDescription{
                FontPath = fontName,
                FontSize = fontSize,
                FontStyle = System  .Drawing.FontStyle.Regular,
                Color = color
            });
        }
        private void GenerateLyrics(List<Sentence> sentences)
        {
            foreach(var sentence in sentences)
            {
                switch(sentence.style)
                {
                    case 0:
                    double width = GetSentenceWidth(sentence);
                    Log(width.ToString());
                    double posX = sentence.position.X - (width/2);
                    foreach(var word in sentence.list)
                    {
                        var texture = font.GetTexture(word.text);
                    
                        var position = new Vector2((float)posX, sentence.position.Y)
                            + texture.OffsetFor(OsbOrigin.Centre) * 0.3f;

                        var sprite = GetLayer("Lyrics").CreateSprite(texture.Path, OsbOrigin.CentreLeft, new Vector2((float)posX, sentence.position.Y));
                        sprite.Fade(word.startTime, sentence.endTime, 1, 1);
                        sprite.Scale(OsbEasing.OutExpo, word.startTime, word.startTime + 1000, 0.4, 0.3);
                        posX += (texture.BaseWidth * 0.3) + wordSpace;
                    }
                    break;
                }
            }
        }
        private double GetSentenceWidth(Sentence sentence)
        {
            double width = 0;
            foreach(var word in sentence.list)
            {
                var texture = font.GetTexture(word.text);
                width += (texture.BaseWidth * 0.3) + wordSpace;
            }
            return width;
        }
        private List<Sentence> LoadLyrics()
        {
            bool isBuilding = false;
            string[] lines = File.ReadAllLines(ProjectPath + "/" + path);
            List<Sentence> sentences = new List<Sentence>();
            Sentence currentSentence = null;
            foreach(var line in lines)
            {
                string[] values = line.Split(',');
                if(line[0] != ' ' && isBuilding)
                {
                    sentences.Add(currentSentence);
                    isBuilding = false;
                }
                    
                if(values[0] == "S")
                {
                    currentSentence = new Sentence(
                        int.Parse(values[1]), 
                        int.Parse(values[2]), 
                        int.Parse(values[3]), 
                        int.Parse(values[4])
                    );
                    
                    isBuilding = true;
                    continue;
                }

                if(isBuilding)
                {   
                    char ID = values[0][1];
                    if(ID == 'W')
                        currentSentence.AddElemement(new Word(int.Parse(values[1]), values[2].Trim('"')));

                    if(ID == 'L')
                    {

                    }
                }
            }
            return sentences;
        }
        private class Sentence
        {
            public List<Word> list = new List<Word>();
            public int style;
            public int endTime;
            public Vector2 position;
            public Sentence(int style, int endTime, int posX, int posY)
            {
                this.style = style;
                this.endTime = endTime;
                this.position = new Vector2(posX, posY);
            }
            public void AddElemement(Word word) => list.Add(word);
        }
        private class Word
        {
            public int startTime;
            public string text;

            public Word(int startTime, string text)
            {
                this.startTime = startTime;
                this.text = text;
            }
        }
    }
}