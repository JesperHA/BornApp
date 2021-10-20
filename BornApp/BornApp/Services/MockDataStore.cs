using BornApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BornApp.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sportscar event", Description="I morgen kan du bl.a. opleve de her biler, når der er @sportscarevent i Bornholms lufthavn fra kl. 11-15!\nI dag (fredag) ml. kl. 16-17 blev de udstillet på Rønne Torv og kl. 18 i dag kan man se dem i Svaneke.\nMan kunne også lige få lov at sidde lidt på en af politiets motorcykler", ImageUrl="https://gcdn.pbrd.co/images/tk6IUvjzRe1h.png?o=1", ImageUrl2="https://gcdn.pbrd.co/images/hFtjT1OFiJDn.jpg?o=1", ImageUrl3="https://gcdn.pbrd.co/images/SRek9TjgIxZM.jpg?o=1" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sportscar event", Description="Sportsbiler i bornholms lufthavn.", ImageUrl="https://gcdn.pbrd.co/images/tk6IUvjzRe1h.png?o=1", ImageUrl2="https://gcdn.pbrd.co/images/tk6IUvjzRe1h.png?o=1", ImageUrl3="https://gcdn.pbrd.co/images/tk6IUvjzRe1h.png?o=1"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sportscar event", Description="Sportsbiler i bornholms lufthavn.", ImageUrl="https://gcdn.pbrd.co/images/tk6IUvjzRe1h.png?o=1", ImageUrl2="https://gcdn.pbrd.co/images/tk6IUvjzRe1h.png?o=1", ImageUrl3="https://gcdn.pbrd.co/images/tk6IUvjzRe1h.png?o=1"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Blåbær", Description="Blåbær selvpluk.", ImageUrl="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1", ImageUrl2="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1", ImageUrl3="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Blåbær", Description="Blåbær selvpluk.", ImageUrl="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1", ImageUrl2="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1", ImageUrl3="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Blåbær", Description="Blåbær selvpluk.", ImageUrl="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1", ImageUrl2="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1", ImageUrl3="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Blåbær", Description="Blåbær selvpluk.", ImageUrl="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1", ImageUrl2="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1", ImageUrl3="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Blåbær", Description="Blåbær selvpluk.", ImageUrl="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1", ImageUrl2="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1", ImageUrl3="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Blåbær", Description="Blåbær selvpluk.", ImageUrl="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1", ImageUrl2="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1", ImageUrl3="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Blåbær", Description="Blåbær selvpluk.", ImageUrl="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1", ImageUrl2="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1", ImageUrl3="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Blåbær", Description="Blåbær selvpluk.", ImageUrl="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1", ImageUrl2="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1", ImageUrl3="https://gcdn.pbrd.co/images/tQ8PUp5e178x.png?o=1" }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}