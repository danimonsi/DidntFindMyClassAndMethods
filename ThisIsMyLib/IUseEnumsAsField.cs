using ThisIsMyEnumLib;

namespace ThisIsMyLib
{
    public class IUseEnumsAsField
    {
        public GreetingsEnum GreetHeyHo = GreetingsEnum.HeyHo;
        public GreetingsEnum GreetHey = GreetingsEnum.Hey;

        public MyEnum ThisShirt = MyEnum.HasPinkShirts;

        //comment fields and uncomment property, this class is found
        //public GreetingsEnum GreetHi
        //{
        //    get { return GreetingsEnum.Hi; }
        //}
    }
}
