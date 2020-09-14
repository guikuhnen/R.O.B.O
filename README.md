# R.O.B.O

### Robô Operacional BinariamenteOrientado

Esse aplicativo possui um back-end em .NET Core 3.1 Web Api e o front-end em Angular 10.

---

### Para rodar o projeto

1. Verifique se possui o .NET Core 3.1 SDK instalado, outras versões podem causar erros na compilação, é recomendado atualizar;
    - Para verificar se possui o .net core instalado utilize o comando ```dotnet --version```

2. Verifique se possui o NodeJS instalado;
    - Para verificar se possui o node instalado (e consequentemente o NPM) utilize o ```comando npm -v```

3. Para rodar a API acesse a pasta do projeto WebApi (\ROBO\API.ROBO), abra um terminal (cmd) e execute o comando: ```dotnet run``` (a base de dados será criada em tempo de execução);f

4. Para rodar o site acesse a pasta do projeto Visual (\ROBO\UI-ROBO), abra um terminal (cmd) e execute os seguintes comandos em sequência:
    - ```npm install``` (instala as dependências, inclusive o AngularCLI);
    - ```npm start``` (ou ```ng serve -o``` caso já possua o AngularCLI instalado);

5. No navegador abra o link http://localhost:4200, a API usa por padrão o https://localhost:5001 ou http://localhost:5000.
