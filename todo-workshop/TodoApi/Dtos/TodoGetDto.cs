namespace TodoApi.Dtos;
public record TodoGetDto(
    int Id,
    String Title,
    bool IsDevelopment
);
