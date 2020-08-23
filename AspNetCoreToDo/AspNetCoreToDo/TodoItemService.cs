using System;
using System.Threading.Tasks;
using Xunit;

namespace AspNetCoreTodo
{
    public class UnitTest1
    {
        public async Task<bool> AddItemAsync(
            TodoItem newItem, ApplicationUser user)
            {
                newItem.Id = Guid.NewGuid();
                newItem.IsDone = false;
                newItem.DueAt = DateTimeOffset.Now.AddDays(3);
                newItem.UserId = user.Id;
                _context.Items.Add(newItem);
                var saveResult = await _context.SaveChangesAsync();
                return saveResult == 1;
            }
    }
}
