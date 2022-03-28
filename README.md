# Bookstore
Web API RESTful em Asp.NET Core para gestão de livros


## Comandos EF:
* update-database -Context ApplicationDbContext (Para gerar a base de dados com toda estrutura)

Ou pode alterar o valor da key **[UseInMemoryDatabase]** para true no file  **appsettings.json**
para poder utilizar o sql in memory

## Frameworks aplicadas no projeto


**Swashbuckle.AspNetCore** - utilizei ela para poder implementar a documentação da API.
**NLog.Config** - utilizei ela para poder implementar o registo de logs em files na API.
**Serilog.AspNetCore** - utilizei ela para poder implementar logs na consola da API.
**AutoMapper** - utilizei ela para poder ter o parse dos meus objectos de entidade de base de dados para um outro objecto com menos informações.
**Microsoft.EntityFrameworkCore.SqlServer/Microsoft.AspNetCore.Identity.EntityFrameworkCore/Microsoft.VisualStudio.Web.CodeGeneration.Design/Microsoft.EntityFrameworkCore.Tools** - utilizei como a ORM da minha API, para poder ter uma abstração com o banco.




## Experiência com o projeto 
   Teóricamente tive de indentificar todas as entidades envolvidas no problema, como foi descrito no readme do challenge, Autor, Genero, e posteriomente identificar quais informações relevantes compunha cada uma delas, tenho reunido tudo isso, passei para a implementação.
   Na parte pratica não tive, tive implementar alguns requistos que não foi pedido no challange mas que eu achei muito importante, como swagger para facilitar os teste e a compressão da API.

## Futuro

Melhorias para o projecto são muitas, basicamente iria implementar autenticação e autorização na API, acrescentaria mais feature nela, como:
**Filtro de livros por categoria ou autor.**
**Paginação no retoro de livros, uma vez que poderemos ter muitos livros em nossa aplicação.**
**Acrescentaria mais campos para as entidades para podermos ter mais informações, como data da publicação do livro, Link da capa do livro...**
**Mais controle nos livros,  entradas e saidas de livros.**
**Implementar rede de fornecedores de livros.**
**Relarório, para se ter uma ideia geral de andam as coisas.**
**Possibilidade de vendas de livros online.**



