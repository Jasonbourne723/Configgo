using Configgo.Model;
using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Mapster;

namespace Configgo.Service
{
    public class VHostService : IVHostService,ITransient
    {
        private readonly IRepository<VHost> _vhostRepository;

        public VHostService(IRepository<VHost> vhostRepository)
        {
            _vhostRepository = vhostRepository;
        }

        public async Task<PagedList<VHostDto>> GetPage(int pageIndex, int pageSize)
        {
            var result = await _vhostRepository.DetachedEntities.ToPagedListAsync(pageIndex, pageSize);
            return result.Adapt<PagedList<VHostDto>>();
        }

        public async Task Add(VHostDto dto)
        {
            await _vhostRepository.InsertNowAsync(dto.Adapt<VHost>());
        }

        public async Task Delete(long id)
        {
            await _vhostRepository.DeleteNowAsync(id);
        }

        public async Task Update(VHostDto dto)
        {
            await _vhostRepository.UpdateNowAsync(dto.Adapt<VHost>());
        }

    }
}