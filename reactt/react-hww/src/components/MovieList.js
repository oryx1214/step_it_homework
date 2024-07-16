import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import axios from 'axios';

function MovieList() {
  const [movies, setMovies] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    const fetchMovies = async () => {
      try {
        const movieIds = ['tt0087884', 'tt0111161', 'tt1375666']; // Примеры ID фильмов
        const requests = movieIds.map(id => {
          return axios.request({
            method: 'GET',
            url: `https://imdb146.p.rapidapi.com/v1/title/`,
            params: { id },
            headers: {
              'x-rapidapi-key': '7907435817mshb814f51ac78669ep174ae3jsn1398c76932a8',
              'x-rapidapi-host': 'imdb146.p.rapidapi.com'
            }
          });
        });

        const responses = await Promise.all(requests);
        const moviesData = responses.map(response => response.data);
        setMovies(moviesData);
      } catch (error) {
        setError('Error fetching movies');
        console.error('Error fetching movies:', error);
      } finally {
        setLoading(false);
      }
    };

    fetchMovies();
  }, []);

  if (loading) return <div>Loading...</div>;

  if (error) return <div>{error}</div>;

  return (
    <div className="movie-list">
      {movies.map(movie => (
        <div key={movie.id} className="movie-item">
          <Link to={`/movies/${movie.id}`}>
            <img src={movie.image_url} alt={movie.title} />
            <h2>{movie.title}</h2>
            <p>{movie.description}</p>
          </Link>
        </div>
      ))}
    </div>
  );
}

export default MovieList;
