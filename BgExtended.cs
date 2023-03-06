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
    public class BgExtended : StoryboardObjectGenerator
    {
        [Configurable]
        public string BackgroundPath = "";
        
        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 0;

        [Configurable]
        public int BeatDivisor = 8;

        public void moveObj(OsbSprite Yaobai,int degree, int offset, bool negative)
        {
            int startWork = 1;
            var startTime2 = 0.0;
            var startPosition2 = Yaobai.PositionAt(startTime2);
            var defaultPosition = Yaobai.PositionAt(startTime2);
            //Log(startPosition2.ToString());
            foreach (var hitobject in Beatmap.HitObjects)
            {
                if ((StartTime != 0 || EndTime != 0) && 
                (hitobject.StartTime < StartTime - 5 || EndTime + (1 * Beatmap.GetTimingPointAt((int)hitobject.StartTime).BeatDuration ) - 5 <= hitobject.StartTime))
                continue;

                var timestep = Beatmap.GetTimingPointAt((int)hitobject.StartTime).BeatDuration / BeatDivisor;
                var startTime = hitobject.StartTime;
                var endTime = hitobject.StartTime;
                var startPosition = hitobject.PositionAtTime(startTime);
                
                if ( negative )
                    startPosition = new Vector2(512, 384) - hitobject.PositionAtTime(startTime);
                
                //var endPosition = hitobject.PositionAtTime(endTime);
                
                //Log(hitobject.PositionAtTime(14810).ToString());
                if(startWork > 1)Yaobai.Move(OsbEasing.None, startTime2 + offset, startTime + offset, defaultPosition + startPosition2 / degree, CommonToVec(defaultPosition.ToString()) + startPosition / degree);
                startTime2 = startTime;
                startPosition2 = startPosition;

                //if (complete) Log((hitobject.EndTime - EndTime ).ToString() + complete.ToString());
                //Log(endPosition.ToString() + ' ' + startTime);
                startWork ++;

            
            }
        }

        public static Vector2 CommonToVec(string str)
        {
            str = str.Replace("(", " ").Replace(")", " "); //将字符串中"("和")"替换为" "
            string[] s = str.Split(',');
            return new Vector2(float.Parse(s[0]), float.Parse(s[1]));
        }


        public override void Generate()
        {
            var bitmap1 = GetMapsetBitmap("sb/bg/bg1.png");
            var layer1 = GetLayer("");
            var bg1 = layer1.CreateSprite("sb/bg/bg1.png", OsbOrigin.Centre);
            
            bg1.Fade(StartTime, 1);
            bg1.Scale(StartTime, 480.0f / bitmap1.Height);

            moveObj(bg1, 300, 0, true);

            var bitmap2 = GetMapsetBitmap("sb/bg/bg2.png");            
            var layer2 = GetLayer("");
            var bg2 = layer2.CreateSprite("sb/bg/bg2.png", OsbOrigin.Centre);
            
            bg2.Fade(StartTime, 1);
            bg2.Scale(StartTime, 480.0f / bitmap2.Height);

            moveObj(bg2, 200, 0, true);
            
            var bitmap3 = GetMapsetBitmap("sb/bg/bg3.png");
            var layer3 = GetLayer("");
            var bg3 = layer1.CreateSprite("sb/bg/bg3.png", OsbOrigin.Centre);
            
            bg3.Fade(StartTime, 1);
            bg3.Scale(StartTime, 480.0f / bitmap3.Height);

            moveObj(bg3, 100, 0, true);
        
        
        }
    }
}
