﻿using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{

    public class MovieRepository : IMovie<Movie>
    {
        private CinemaContext _db;

        public MovieRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Movie> CreateEntity(Movie entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();

            return await _db.Movies.Include(x => x.Screenings).FirstOrDefaultAsync(e => e.Id == entity.Id);
        }

        public async Task<Screening> CreateEntityScreening(Screening screening)
        {
            await _db.Screenings.AddAsync(screening);
            await _db.SaveChangesAsync();

            return screening;
            
        }

        public async Task<Movie> DeleteEntity(int id)
        {
            var entity = await _db.Movies.FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
                return null;

            _db.Movies.Remove(entity);
            _db.SaveChangesAsync();

            return entity;
        }

        public async Task<List<Movie>> GetAllEntities()
        {
            return await _db.Movies.ToListAsync();
        }

        public async Task<Movie> GetAnEntityById(int id)
        {
            return await _db.Movies
                .Include(x => x.Screenings)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Movie> UpdateEntity(Movie entity, int searchId)
        {
            var target = await _db.Movies
                .FirstOrDefaultAsync(x => x.Id == searchId);

            target.Title = entity.Title;
            target.Rating = entity.Rating;
            target.Description = entity.Description;
            target.UpdatedAt = DateTime.UtcNow;

            await _db.SaveChangesAsync();
            return target;
        }
    }
}
