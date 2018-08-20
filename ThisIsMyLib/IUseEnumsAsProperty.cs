using ThisIsMyEnumLib;

namespace ThisIsMyLib
{
    public class IUseEnumsAsProperty
    {
        public GreetingsEnum GreetHey
        {
            get { return GreetingsEnum.Hey; }
        }

        public GreetingsEnum GreetHeyHo
        {
            get { return GreetingsEnum.HeyHo; }
        }


    }
}
