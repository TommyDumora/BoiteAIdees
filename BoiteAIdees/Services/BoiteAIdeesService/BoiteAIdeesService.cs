﻿using BoiteAIdees.Context;
using BoiteAIdees.Models.Domaine;
using Microsoft.EntityFrameworkCore;

namespace BoiteAIdees.Services.BoiteAIdeesService
{
    /// <summary>
    /// Implémentation du service BoiteAIdees.
    /// </summary>
    public class BoiteAIdeesService : IBoiteAIdeesService
    {
        private readonly BoiteAIdeesContext _context;

        /// <summary>
        /// Constructeur de la classe BoiteAIdeesService.
        /// </summary>
        /// <param name="context">Contexte de la base de données BoiteAIdees.</param>
        public BoiteAIdeesService(BoiteAIdeesContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Récupère toutes les idées.
        /// </summary>
        /// <returns>Liste d'idées.</returns>
        public async Task<List<Ideas>> GetAllIdeas()
        {
            return await _context.Ideas
                .Include(i => i.Category)
                .Include(i => i.User)
                .ToListAsync();
        }

        /// <summary>
        /// Récupère une idée par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant de l'idée.</param>
        /// <returns>Une idée spécifique ou null si non trouvée.</returns>
        public async Task<Ideas> GetIdeaById(int id)
        {
            var idea = await _context.Ideas.FirstOrDefaultAsync(i => i.IdeaId == id);

            return idea ?? throw new InvalidOperationException("L'idée avec cet identifiant est introuvable.");
        }

        /// <summary>
        /// Permet de créer une idée.
        /// </summary>
        /// <param name="newIdea">Représente une idée.</param>
        /// <returns>Une idée est ajoutée.</returns>
        public async Task<Ideas> AddIdea(Ideas newIdea)
        {
            _context.Ideas.Add(newIdea);
            await _context.SaveChangesAsync();
            return newIdea;
        }

    }
}
