using StorybrewCommon.Scripting;

namespace StorybrewScripts
{
    public class BGRemover : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var BackgroundPath = Beatmap.BackgroundPath;
            var bg = GetLayer("").CreateSprite(BackgroundPath);
            bg.Fade(0, 0f);
        }
    }
}
