using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rpg.Dtos.Character;

namespace rpg.Services.CharacterService
{
  public class CharacterService : ICharacterService
  {
    private static List<Character> characters = new List<Character> {
        new Character(),
        new Character { Id = 1, Name = "Sam" }
    };

    public async Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter)
    {
      var serviceResponse = new ServiceResponse<List<GetCharacterDTO>>();
      characters.Add(newCharacter);
      serviceResponse.Data = characters;
      return serviceResponse;
    }

    public async Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters()
    {
      var serviceResponse = new ServiceResponse<List<GetCharacterDTO>>();
      serviceResponse.Data = characters;
      return serviceResponse;
    }

    public async Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id)
    {
      var serviceResponse = new ServiceResponse<List<GetCharacterDTO>>();
      var character = characters.FirstOrDefault(c => c.Id == id);

      if (character is not null)
      {
        serviceResponse.Data = character;

      }
      return serviceResponse;
    }
  }
}