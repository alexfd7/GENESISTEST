#  .NET Developer SR - B3.

PROJETO DE AVALIAÇÃO PARA DESENVOLVEDOR



### 📋 Pré-requisitos

```
.Net Core 6.0
NodeJs
Angular CLI

```

## ⚙️ Executando o projeto - BackEnd


### Visual Studio (1ª opção)

Abrir arquivo da solução (.sln) pelo Visual Studio, definir o projeto WebAPI como projeto de inicialização e executar projeto.

### Visual Studio Code (2ª opção)

Dentro da solução, acessar a pasta do projeto WebApi 

```
cd WebApi
```

Executar comando

```
dotnet watch run --launch-profile WebApiDevelopment
```

## ⚙️ Executando o projeto - FrontEnd


Dentro da solução, acessar a pasta do projeto AngularApp 

```
cd AngularApp
```

Baixar e instalar as dependências do projeto

```
npm install
```

Para executar a aplicação, rodar comando angular cli

```
ng serve --open --configuration development
```

OU


```
npm run dev
```

## 🎯 Executando Testes - FrontEnd

Utilizado  [Karma](https://karma-runner.github.io) -  Ferramenta para testes unitários no front-end

Para executar testes
```
ng test
```

OU

```
ng test --code-coverage
```

![image](https://github.com/alexfd7/GENESISTEST/assets/1108262/29965718-846c-4c67-8bd9-674558d3bf65)


## 🎯 Executando Testes - BackEnd

Utilizado [FineCodeCoverage](https://marketplace.visualstudio.com/items?itemName=FortuneNgwenya.FineCodeCoverage) - Ferramenta de testes disponível para Visual Studio Community


![image](https://github.com/alexfd7/GENESISTEST/assets/1108262/104b1798-a871-40a1-bc2a-71071e6ae4ae)


## 🛠️ Construído com

Ferramentas utilizadas no projeto

* [NetCore](https://learn.microsoft.com/en-us/dotnet/) - Uma plataforma para desenvolvimento de aplicativos em geral.
* [AngularCli](https://angular.io/cli) - Ferramenta de shell de comando para inicializar, desenvolver, estruturar e manter  aplicativos em Angular
* [SonarLint](https://www.sonarsource.com/products/sonarlint/) - Detecte problemas de codificação em tempo real e obtenha orientações claras sobre como corrigi-los.
* [Swagger](https://swagger.io/) -  Ferramenta para ajudar a projetar e documentar APIs em escala.
* [Karma](https://karma-runner.github.io) -  Ferramenta para testes unitários no front-end


## ✒️ Autores

[Alexandre Duarte](https://github.com/alexfd7) 

---
