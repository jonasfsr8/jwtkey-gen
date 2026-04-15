# 🔐 JWT Key Generator

Aplicação de console em C# para geração de uma chave segura (secret key)
para uso em autenticação com JWT (JSON Web Tokens).

## 📌 Sobre o projeto

Este projeto gera uma chave criptograficamente segura utilizando o
namespace `System.Security.Cryptography`, ideal para ser usada como
`secret` na assinatura de tokens JWT.

A chave é gerada com 64 bytes aleatórios e convertida para o formato
Base64.

------------------------------------------------------------------------

## ⚙️ Como funciona

O programa executa os seguintes passos:

1.  Gera 64 bytes aleatórios usando um gerador criptográfico seguro
2.  Converte os bytes para uma string Base64
3.  Exibe a chave no console

------------------------------------------------------------------------

## 🧪 Código fonte

``` csharp
using System.Security.Cryptography;

namespace jwtkey
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyBytes = RandomNumberGenerator.GetBytes(64);
            var key = Convert.ToBase64String(keyBytes);

            Console.WriteLine($"jwt_key: {key}");
        }
    }
}
```

------------------------------------------------------------------------

## 🚀 Como executar

### Pré-requisitos

-   .NET 6 ou superior instalado

### Executando o projeto

``` bash
dotnet run
```

------------------------------------------------------------------------

## 🔑 Exemplo de saída

    jwt_key: SUA_CHAVE_GERADA_AQUI

------------------------------------------------------------------------

## 📦 Uso prático

Exemplo em `appsettings.json`:

``` json
"Jwt": {
  "Key": "SUA_CHAVE_GERADA_AQUI"
}
```