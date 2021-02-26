using AutoMapper;

namespace BPMC.Common.Utils
{
    public class AutoMapperUtils
    {
        public static TDestination autoMap<TSource, TDestination>(object source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<TSource, TDestination>();
            });
            TDestination dest = Mapper.Map<TDestination>(source);
            return dest;
        }
    }
}
