namespace Configgo.Service
{
    public interface IVHostService
    {
        Task Add(VHostDto dto);
        Task Delete(long id);
        Task<PagedList<VHostDto>> GetPage(int pageIndex, int pageSize);
        Task Update(VHostDto dto);
    }
}