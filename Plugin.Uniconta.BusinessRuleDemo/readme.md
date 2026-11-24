# HelloWorld business-rule plugin

Registers the `MyPlugin.HelloWorld` function from the example. Calling
`HelloWorld()` writes `Hello, world!` to the information log and returns that string.

## Build and install

1. Create a C# **Class Library (.NET Framework)** project named `HelloWorldPlugin`.
   Use .NET Framework 4.6.2 and reference `ClientTools.dll` from the matching
   Uniconta installation. Add the example as `HelloWorld.cs` and build it.
2. Copy `HelloWorldPlugin.dll` to the configured Uniconta plugin folder.
   The default folder is `C:\Uniconta\PluginPath\`.
3. Ensure Business Rules is enabled for the company.

Keep the function class public and non-sealed, with a public parameterless
constructor. The example's implicit constructor meets this requirement.

## Register the DLL

1. Open the company in Uniconta Desktop.
2. Go to **Tools > Menus > User Plugin** and select **Add**.
3. Enter these values (labels may vary with the client language):

   | Field | Value |
   | --- | --- |
   | Name | `HelloWorld test` |
   | Plugin type | `BusinessRule` |
   | Name of DLL | `HelloWorldPlugin` (without `.dll`) |
   | Class name | `MyPlugin.HelloWorld` |
   | Control | Leave blank; this function is not attached to a page |
   | Disable | Unchecked |
   | For company | The company ID being used for this check |

4. Save, then restart Uniconta and open the company again.

The DLL is scanned for business-rule functions automatically. Registering it
as `BusinessRule` makes it load when the company opens; no menu-button plugin
or manual registration call is needed.

## Call it at startup

1. Open **Business Rules**, add a rule, and select the **Startup** trigger.
2. Choose **Uniconta Script** and enter:

   ```javascript
   HelloWorld();
   ```

   For a **C#** rule, use this instead:

   ```csharp
   ExecuteFunction("HelloWorld");
   ```

3. Save and reopen the company to trigger the rule.
4. Check the information log for `Hello, world!`.

If the function is not found, check the DLL location, `BusinessRule` plugin type,
company restriction, and that neither the plugin nor Business Rules is disabled.
After rebuilding the DLL, close Uniconta, replace the file, and restart it.

## References

- [Unipedia: installing a plugin](https://www.uniconta.com/developers-unipedia-global/use-uniconta-plugin/)
- [Unipedia: business-rule plugin functions](https://www.uniconta.com/developers-unipedia-global/business-rules-user-plugins-developer-guide/)
- [Unipedia: creating business rules](https://www.uniconta.com/unipedia-global/business-rules/)
