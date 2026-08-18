using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;

var issuer = "GateKeeper.Auth";
var audience = "GateKeeper.Api";
var key = "f7f37e14-1e00-49ea-8d79-6725ca75ca09";

//создаем скретный ключ 
var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
//подписываем его HMAC-256
var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
//создаем токен 
var token = new JwtSecurityToken(
    issuer : issuer, 
    audience : audience,
    expires: DateTime.UtcNow.AddMinutes(120),
    signingCredentials: signingCredentials);
//добавляем обработчик 
var  handler = new JwtSecurityTokenHandler();
//сереализуем в строку для чтения
var jwt = handler.WriteToken(token);
Console.WriteLine(jwt);

/*
 * Encoding.UTF8.GetBytes -> строка secret превращается в byte[]
   SymmetricSecurityKey -> объект криптографического ключа
   SigningCredentials -> чем + каким алгоритмом подписывать
   JwtSecurityToken  -> объект токена
   WriteToken    -> объект превращается в JWT-строку
 */