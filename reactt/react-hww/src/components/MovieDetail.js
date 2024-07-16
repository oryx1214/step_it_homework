import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import axios from 'axios';
import MovieItem from './MovieItem';

function MovieDetail() {
  const { id } = useParams();
  const [movie, setMovie] = useState(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    const fetchMovie = async () => {
      try {
        const response = await axios.request({
          method: 'GET',
          url: `https://imdb146.p.rapidapi.com/v1/title/`,
          params: { id },
          headers: {
            'x-rapidapi-key': '7907435817mshb814f51ac78669ep174ae3jsn1398c76932a8',
            'x-rapidapi-host': 'imdb146.p.rapidapi.com'
          }
        });
        setMovie(response.data);
      } catch (error) {
        setError('Error fetching movie data');
        console.error('Error fetching movie data:', error);
      } finally {
        setLoading(false);
      }
    };

    fetchMovie();
  }, [id]);

  if (loading) return <div>Loading...</div>;

  if (error) return <div>{error}</div>;

  if (!movie) return <div>Movie not found</div>;

  return <MovieItem movie={movie} />;
}

export default MovieDetail;
