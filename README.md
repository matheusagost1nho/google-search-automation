<h1 align="center">Automação do Google Search</h1>

Teste automatizado para verificar a relevância dos resultados do google search, utilizando C#, Selenium WebDriver com o .Net.

Instale as dependências necessárias para o desenvolvimento do projeto, como o NUnit e o Selenium, assim como o download dos web drivers apropriados para o <a href="https://chromedriver.chromium.org/downloads" target="_blank" >Chrome</a> e o <a href="https://github.com/mozilla/geckodriver" target="_blank">Firefox</a>, de acordo com seu Sistema Operacional. 
Configure o ambiente de teste importando os namespaces necessários para a linguagem C#. Crie uma nova classe adicionando o atributo OneTimeSetUp e outra com OneTimeTearDown.
No método OneTimeSetUp, crie uma nova instância do ChromeDriver e/ou FirefoxDriver e especifique o caminho para a pasta de drivers.
Crie os métodos de teste e utilize os métodos do Selenium para navegar até o site desejado, interagir com elementos da página e recuperar os resultados da pesquisa.
No método OneTimeTearDown, use o método Quit para fechar o web driver.

#Autor
Matheus Agostinho



