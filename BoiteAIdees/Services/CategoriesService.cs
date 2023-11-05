﻿using BoiteAIdees.Context;
using BoiteAIdees.Models.Domaine;
using Microsoft.EntityFrameworkCore;

namespace BoiteAIdees.Services
{
    /// <summary>
    /// Service de gestion des catégories.
    /// </summary>
    public class CategoriesService
    {
        private readonly BoiteAIdeesContext _context;

        /// <summary>
        /// Constructeur de la classe CategoriesService.
        /// </summary>
        /// <param name="context">Contexte de la base de données BoiteAIdees.</param>
        public CategoriesService(BoiteAIdeesContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Récupère toutes les catégories.
        /// </summary>
        /// <returns>Liste de catégories.</returns>
        public async Task<List<Categories>> GetAllCategories()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
