﻿using Repositories.Models;

namespace Repositories
{
    public class OriginalGemstoneRepository
    {
        private JeweleryOrderProductionContext? _context;

        public List<Gemstone> GetAllGemstones()
        {
            _context = new JeweleryOrderProductionContext();
            return _context.Gemstones.ToList();
        }

    }
}
