
using Microsoft.AspNetCore.Http.HttpResults;
using MinatureNoteBookPortalApi.Dtos.Miniature;
using MinatureNoteBookPortalApi.Models;

namespace MinatureNoteBookPortalApi.Mappers
{
    public static class MianitureMappers
    {
        public static MianiatureDto ToMiniatureDto(this Miniature miniatureModel)
        {
            return new MianiatureDto
            {
                Name = miniatureModel.Name,
                Manufactured = miniatureModel.Manufactured,
                MainImageUrl = miniatureModel.MainImageUrl,
                Description = miniatureModel.Description,
                LastEdited = miniatureModel.LastEdited,
                CreatedOn = miniatureModel.CreatedOn,
            };
        }
        public static Miniature ToMiniatureFromCreateDTO(this CreateMiniatureRequestDto miniature)
        {
            return new Miniature
            {
               
                Name = miniature.Name,
                Manufactured = miniature.Manufactured,
                MainImageUrl = miniature.MainImageUrl,
                Description = miniature.Description,
                LastEdited = miniature.LastEdited,
                CreatedOn = miniature.CreatedOn,
            };
        }
    }
}
