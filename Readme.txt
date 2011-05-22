 ___             _ __  __
| _ \___ __ _ __| |  \/  |___
|   / -_) _` / _` | |\/| / -_)
|_|_\___\__,_\__,_|_|  |_\___|

Compliments MvcTurbine.EmbeddedViews by allowing embedded resources as well.

NOTES

Do not use a catch all route. Doing so will block access to the virtual path
provider for the Content and Scripts folders.

Use the convention "SiteName.ProjectName" for embedded projects. This makes
the resource name be "SiteName.ProjectName.Content.FileName.txt" and makes
the file path be "~/ProjectName/Content/FileName.txt".