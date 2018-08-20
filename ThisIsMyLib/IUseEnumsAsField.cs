using ThisIsMyEnumLib;

namespace ThisIsMyLib
{
    public class IUseEnumsAsField
    {
        public GreetingsEnum GreetHeyHo = GreetingsEnum.HeyHo;
        public GreetingsEnum GreetHey = GreetingsEnum.Hey;


        //comment fields and uncomment property, this class is found
        //public GreetingsEnum GreetHi
        //{
        //    get { return GreetingsEnum.Hi; }
        //}
    }
}
