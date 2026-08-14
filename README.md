## Hacer migraciones

```bash
dotnet ef migrations add InitialMigration # Cuando no hay ninguna tabla

dotnet ef migrations add CreateTableProduct #Migrar una tabla especifica

dotnet ef database update
```

```bash
dotnet new class -n NombreClase -o Ubicacion
```

```bash
dotnet new apicontroller -n NombreDeTuControlador
```

# TODO:
- Validar con `.editorconfig` la nomenclatura de los nombres de los métodos de las interfaces, no validan PascalCase