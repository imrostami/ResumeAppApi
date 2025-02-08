using ResumeAppApi.Domain.Entities.ContentStorageAgg;

namespace ResumeAppApi.Infrustructre.Repositories.ContentStorageRepsitories;

public class ContentStorageRepository(AppDbContext context) : IContentStorageRepository
{
	public async Task<ContentStorage> CreateAsync(ContentStorage entity)
	{
		var isExistStorage = await context.ContentStorages
			.AnyAsync(x => x.Name == entity.Name);

		if (isExistStorage)
			return null;

		await context.ContentStorages.AddAsync(entity);
		await context.SaveChangesAsync();
		return entity;
	}

	public async Task<bool> DeleteAsync(ContentStorage entity)
	{
		var isExistStorage = await context.ContentStorages
			.AnyAsync(x => x.Name == entity.Name);

		if (!isExistStorage)
			return false;

		context.ContentStorages.Remove(entity);
		await context.SaveChangesAsync();
		return true;
	}

	public async Task<bool> DeleteAsync(int id)
	{
		var storage = await context.ContentStorages
			.FirstOrDefaultAsync(x => x.StorageId == id);

		if (storage is null)
			return false;

		context.ContentStorages.Remove(storage);
		await context.SaveChangesAsync();
		return true;
	}

	public async Task<IEnumerable<ContentStorage>> GetAll()
		=> await context.ContentStorages.ToListAsync();

	public async Task<ContentStorage?> GetBy(int id)
		=> await context.ContentStorages
			.FirstOrDefaultAsync(x => x.StorageId == id);

	public async Task<ContentStorage?> GetByName(string name)
		=> await context.ContentStorages
			.FirstOrDefaultAsync(x => x.Name == name);



	public async Task<ContentStorage> UpdateAsync(ContentStorage entity)
	{
		context.ContentStorages.Update(entity);
		await context.SaveChangesAsync();
		return entity;
	}
}
