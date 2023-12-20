Projeto: Credenciamento de Streaming (CREST)

Objetivo:
Desenvolver um sistema de credenciamento eficiente para clientes interessados em se credenciar nos serviços de streaming especificados, garantindo a integridade e consistência das solicitações, notificando o cliente ao término do processo, e registrando todas as transações no banco de dados.
Funcionalidades:

Credenciamento de Cliente:
O cliente solicita um pedido único de credenciamento.
Inclusão dos serviços desejados (Netflix, Prime Video, Disney, Globo Play, HBO Max, Apple TV, Claro Video, Canto Karaoke, Telecine, Star +).
Notificação ao cliente após a conclusão do credenciamento.

Pré-Requisitos:
⦁	Tempo de resposta inferior a dois segundos.
⦁	Desfaz todo o processo se houver uma falha em uma solicitação.
Catálogos de Serviço:
⦁	Lista dos serviços disponíveis: Netflix, Prime Video, Disney, Globo Play, HBO Max, Apple TV, Claro Video, Canto Karaoke, Telecine, Star +.
⦁	Integração Apple TV:
a.	Requisição com informação de URL.
b.	Tratamento de resposta em outra API.
c.	Utilização de RDP para aguardar resposta assíncrona.

Banco de Dados:
⦁	MongoDB para armazenar dados de credenciamento e logs.

Tecnologias Utilizadas:
⦁	Linguagem: C#
⦁	Framework: .NET 8
⦁	Mensageria: MassTransit com SAGA para garantir transações consistentes.

Controle de Falhas:
⦁	SAGA para garantir atomicidade nas transações.
⦁	RDP para controle de fluxo assíncrono no caso da Apple TV.
⦁	Notificações em caso de falhas.
⦁	Registro de Solicitações:
a.	Todas as solicitações e transações devem ser registradas no banco de dados como logs.

Avaliação:
⦁	Implementação de Testes Unitários para garantir a robustez do sistema.
⦁	Adoção dos princípios SOLID para melhorar a manutenibilidade e extensibilidade.
⦁	Utilização de Clean Architecture para promover uma estrutura organizada e modular do código.

Considerações Finais:
O projeto visa criar um sistema de credenciamento eficiente, seguro e de fácil manutenção, utilizando tecnologias modernas e práticas de desenvolvimento de software. A estrutura do código deve ser limpa e organizada, seguindo as boas práticas de arquitetura e design. Testes unitários devem ser elaborados para garantir a qualidade e confiabilidade do sistema.
