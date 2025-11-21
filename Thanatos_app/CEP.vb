Imports System.Net.Http
Imports Newtonsoft.Json

Module CEP
    Public Class CepResponse
        Public Property cep As String
        Public Property logradouro As String
        Public Property bairro As String
        Public Property localidade As String
    End Class
    Public Async Function BuscarCEP(cep As String) As Task(Of CepResponse)
        Dim url As String = $"https://viacep.com.br/ws/{cep}/json/"

        Using client As New HttpClient()
            Dim resposta = Await client.GetStringAsync(url)
            Return JsonConvert.DeserializeObject(Of CepResponse)(resposta)
        End Using
    End Function

End Module
