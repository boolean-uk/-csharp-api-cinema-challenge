namespace api_cinema_challenge.DTO.Response
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ScreeningMovieDTO> Screenings { get; set; } = new List<ScreeningMovieDTO>();
    }
}
