namespace Builder
{
    public class Director
    {
        public void Build(Builder _builder)
        {
            _builder.BuildSection1();
            _builder.BuildSection2();
        }
    }
}