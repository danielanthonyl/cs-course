using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rpg.Dtos.Character;

namespace rpg.Services.CharacterService
{
  public interface ICharacterService
  {
    Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters();
    Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id);
    Task<ServiceResponse<List<AddCharacterDTO>>> AddCharacter(Character newCharacter);
  }
}