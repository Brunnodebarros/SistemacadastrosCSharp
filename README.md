# SistemacadastrosCSharp

Banco de dados utilizado: Microsoft MySQL(necessário instalar o Xampp).

Para configurar a conexão com o banco de dados:  

public string conect = "SERVER=localhost; DATABASE=appven; UID=root; PWD=; PORT=3306;";
Utilizei appven como nome do banco de dados, senha vazia.
 Abrir no Visual Studio para acessar os formulários.


Diretorios:
Instalador: setup\Sistema\Debug
Scripts de criação das tabelas e inserções: TesteJRapp\ScriptsSQL



![image](https://user-images.githubusercontent.com/39539138/224508264-61a86258-c804-461c-adc0-fd632ee81588.png)
Validações, cadastro de cliente:

• Essa tela só permitirá adicionar um novo cliente
• Os únicos botões habilitados é new para novo cliente e o filtro para pesquisar clientes.
• Ao clicar em New os botões de alterar e excluir ficaram desabilitados.
• Ao clicar em cancelar todos os botões serão desabilitados em excesso o botão de pesquisa e o new.
• só serão aceitos clientes com nome e sobrenome,  só o nome ocorrerá um erro.
• Se o usuários clicar duas vezes na gride de pesquisa, será exibidos a lista com todos os clientes. Nesse caso os botões de New, save e pesquisa estarão desabilitados, sendo possível clicar em cancelar e a tela voltará ao início.

![image](https://user-images.githubusercontent.com/39539138/224508320-a3b3cbaf-c45c-4ece-b5a9-f54a8486aed3.png)

A tela de cadastro de produtos segue as mesmas validações da tela de cadastro de clientes.

Existe a tela de cadastro de pedido de compra, mas ainda não foi finalizada. ):

![image](https://user-images.githubusercontent.com/39539138/224508541-6b158b9c-0dd1-4af8-ad2f-fb3cfa0a34f1.png)

quando acessar o menu acima, referente à venda, abre a tela para selecionar o cliente para qual a venda será feita:

![image](https://user-images.githubusercontent.com/39539138/224508582-54804639-7b03-49bb-af00-fce81ce01d7b.png)
![image](https://user-images.githubusercontent.com/39539138/224508598-9ae45073-574f-44f1-b634-4b5205c5568b.png)

Ao dar dois clicles no cliente, abre a tela de cadastro de pedido de compra, onde somente o campo de quantidade(Amount) e mostrar produtos(show) estão ativos:
![image](https://user-images.githubusercontent.com/39539138/224508661-4931b9dd-fcc7-4cb0-849d-e218db2cda3c.png)







https://user-images.githubusercontent.com/39539138/224508830-d1bbcb7d-7532-4318-9afd-ae4155c2fb46.mp4





