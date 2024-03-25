using MinatureNoteBookPortalApi.Controllers;
using MinatureNoteBookPortalApi.Dtos.Miniature;

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
                MainImageUrl = miniatureModel.MainImageUrl
            };
        }
    }
}
