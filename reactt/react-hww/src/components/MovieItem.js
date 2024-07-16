import React from 'react';

function MovieItem({ movie }) {
  return (
    <div className="movie-detail">
      <img src={movie.image_url} alt={movie.title} />
      <h1>{movie.title}</h1>
      <p>{movie.description}</p>
      <div className="showtimes">
        <h2>Сеансы</h2>
        <ul>
          {movie.showtimes ? movie.showtimes.map((showtime, index) => (
            <li key={index}>{showtime}</li>
          )) : <li>Нет сеансов</li>}
        </ul>
      </div>
    </div>
  );
}

export default MovieItem;
