open System.Net.Http
open System.Windows.Forms
open System

[<EntryPoint>]
[<STAThread>]
let main argv = 
    let items = argv.Length
    printfn "Passed in %d items: %A" items argv

    let httpClient = new HttpClient()
    //let fsharpOrgContent = async {
    //    let! data = httpClient.GetStringAsync("http://fsharp.org") |> Async.AwaitTask
    //    return data
    //} 

    let fsharpOrgContent = httpClient.GetStringAsync("http://fsharp.org") |> Async.AwaitTask |> Async.RunSynchronously

    let browser = new WebBrowser()
    browser.ScriptErrorsSuppressed <- true
    browser.Dock <- DockStyle.Fill
    browser.DocumentText <- fsharpOrgContent

    let richTextBox = new RichTextBox();
    richTextBox.Dock <- DockStyle.Fill
    richTextBox.Text <- fsharpOrgContent

    let form = new Form()
    //form.Controls.Add browser
    form.Controls.Add richTextBox
    form.Show()

    printfn "%s" fsharpOrgContent

    Console.ReadKey()

    1
