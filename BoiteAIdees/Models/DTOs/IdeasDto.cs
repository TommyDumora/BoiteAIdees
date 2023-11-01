﻿namespace BoiteAIdees.Models.DTOs
{
    /// <summary>
    /// Représente une idée au format DTO (Data Transfer Object).
    /// </summary>
    public class IdeasDto
    {
        /// <summary>
        /// Obtient ou définit l'identifiant de l'idée.
        /// </summary>
        public int IdeaId { get; set; }

        /// <summary>
        /// Obtient ou définit le titre de l'idée.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Obtient ou définit la description de l'idée.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Obtient ou définit le nom de la catégorie associée à l'idée.
        /// </summary>
        public string? CategoryName { get; set; }

        /// <summary>
        /// Obtient la date de la création de l'idée.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Obtient le prénom de l'utilisateur.
        /// </summary>
        public string? UserFirstName { get; set; }

        /// <summary>
        /// Obtient le nom de l'utilisateur.
        /// </summary>
        public string? UserLastName { get; set; }
    }
}
