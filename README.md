# GRUPO_D.PAMPAZON

Prototipo en Windows Forms (.NET 10) de los casos de uso del depósito de Pampazon.
Solo se usan los controles y propiedades de la clase "Windows Forms" de la cátedra.

## Módulos

| CU | Carpeta / namespace | Formulario | Procesos | Campos de la planilla |
|---|---|---|---|---|
| CU1 | `CU1_GestionPedidosSeleccion` | `GestionPedidosSeleccionForm` | P01 Aceptar, P02 Rechazar, P03 Cortes de selección | A.1–A.6, B.1–B.4 |
| CU2 | `CU2_SeleccionEntregaMercaderia` | `SeleccionEntregaMercaderiaForm` | A02 Seleccionar y entregar, I03 Servicio a cobrar | C.1–C.6 |
| CU3 | `CU3_EmpaquetadoPreparacionEntregas` | `EmpaquetadoPreparacionEntregasForm` | P04 Empaquetar, P05 Emitir orden de entrega | D.1–D.9 |
| CU4 | `CU4_RecepcionDespachoPedidos` | `RecepcionDespachoPedidosForm` | E01 Recibir, E03 Despachar (con E02, E04, E05) | E.1–E.5, F.1–F.6 |

`Comun/` reúne lo que usan todas las pantallas: mensajes (`Mensajes`), validaciones de formato y largo
(`Validaciones`), estados, modalidades, orígenes y numeración de documentos (`Catalogos.cs`).

`Program.cs` abre CU1. Para probar otra pantalla, cambiar el formulario de `Application.Run`.

## Convención de nombres

- **Carpeta y namespace:** `CU{n}_{NombreDelCU}` → `GRUPO_D.PAMPAZON.CU{n}_{NombreDelCU}`.
- **Formulario:** `{NombreDelCU}Form`, uno por caso de uso.
- **Controles:** prefijo de tipo + nombre completo en PascalCase, sin abreviaturas.

  | Control | Prefijo | Ejemplo |
  |---|---|---|
  | Label | `lbl` | `lblCliente` |
  | TextBox | `txt` | `txtCliente` |
  | ComboBox | `cbo` | `cboFiltroCliente` |
  | DateTimePicker | `dtp` | `dtpFechaCorte` |
  | CheckBox | `chk` | `chkConformidadRetiro` |
  | RadioButton | `rdo` | `rdoPrimerCorte` |
  | Button | `btn` | `btnAceptarOrden` |
  | ListView | `lv` | `lvOrdenesPendientes` |
  | ColumnHeader | `col` | `colOrdenesPendientesNumero` |
  | GroupBox | `grp` | `grpDatosCorte` |

- **Etiqueta y campo** llevan el mismo nombre: `lblFechaRetiro` ↔ `dtpFechaRetiro`.
- **Filtros de búsqueda:** `Filtro` delante del dato (`txtFiltroOrden`, `cboFiltroOrigen`).
- **Botones:** verbo + objeto (`btnValidarDisponibilidad`, `btnEmitirDocumento`).
- **Columnas:** `col` + nombre de la lista sin `lv` + dato (`colRenglonesRetirada`). El código usa `.Index`
  de la columna, nunca un número fijo.
- **Eventos:** `{control}_{Evento}` (`btnBuscar_Click`, `lvOrdenesAsignadas_SelectedIndexChanged`).
- **Textos de ayuda:** `lblAyuda{Tema}`; resultado de una acción: `lblResultado{Accion}`.
- **Datos de prueba:** se cargan en `CargarDatosPrueba()` de cada formulario, no en el Designer.
