# Bexs Teste
> Sistema destribuido em api e console para calcular a rota mais barata entre dois ponto.

Atravez da leitura de em arquivo csv o sistema é capaz de calcular qual será a rota mais barata utilizando as inforamções imputadas de origem e destino.

![](../header.png)

## Instalação

MS Visual Studio 2019

## Exemplo de uso

_Arquivo csv_ 

Verifique se o computador posuiu o seguinte caminho: C:\Temp, caso possitivo adicione um aquivo com o seguinte nome e extensão: bexs.csv

Exemplo de arquivo:
```
GRU;BRC;10
BRC;SCL;5
GRU;CDG;75
GRU;SCL;20
GRU;ORL;56
ORL;CDG;5
SCL;ORL;20
```

Para iniciar o projeto, abra-o no Visual Studio 2019 apos a IDE carregar a solução aperte F5 e os dois projetos (API, Console) serão iniciados.

_URL para API_ 

https://localhost:44363/api/route/{Origem}/{Destino}

_Ex:_
https://localhost:44363/api/route/GRU/CDG


## Configuração para Desenvolvimento

Clique com o botão direito na solução aberto e selecione a opção "Restore NuGet Packages"


## Histórico de lançamentos

* 0.1.0
    * O primeiro lançamento adequado
    * Implementação da leitura do aquivo.
* 0.0.1
    * Trabalho em andamento

## Meta

José Guilherme – jguilhermemn@outlook.com

[https://github.com/jguilhermemn/github-link](https://github.com/jguilhermemn/)

## Contributing

1. Faça o _fork_ do projeto (<https://github.com/yourname/yourproject/fork>)
2. Crie uma _branch_ para sua modificação (`git checkout -b feature/fooBar`)
3. Faça o _commit_ (`git commit -am 'Add some fooBar'`)
4. _Push_ (`git push origin feature/fooBar`)
5. Crie um novo _Pull Request_

[npm-image]: https://img.shields.io/npm/v/datadog-metrics.svg?style=flat-square
[npm-url]: https://npmjs.org/package/datadog-metrics
[npm-downloads]: https://img.shields.io/npm/dm/datadog-metrics.svg?style=flat-square
[travis-image]: https://img.shields.io/travis/dbader/node-datadog-metrics/master.svg?style=flat-square
[travis-url]: https://travis-ci.org/dbader/node-datadog-metrics
[wiki]: https://github.com/seunome/seuprojeto/wiki
