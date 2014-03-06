using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private void UploadImage()
    {
        FileUpload fuGameImage = (FileUpload)dvGame.FindControl("fuGameImage");
        Image GameImage = (Image)dvGame.FindControl("imgGame");
        string sVirtualFolder = "~/GamePics/";
        string sPhysicalFolder = Server.MapPath(sVirtualFolder);
        string sFileName = Guid.NewGuid().ToString();
        string sExtension = System.IO.Path.GetExtension(fuGameImage.FileName);

        fuGameImage.SaveAs(System.IO.Path.Combine(sPhysicalFolder, sFileName + sExtension));
        GameImage.ImageUrl = sVirtualFolder + sFileName + sExtension;
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        dgvGames.DataBind();
    }
    protected void dvGame_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        dgvGames.DataBind();
    }
    protected void dvGame_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        dgvGames.DataBind();
    }
    protected void dvGame_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
    {
        dgvGames.DataBind();
    }
    protected void dvGame_ItemInserting(object sender, DetailsViewInsertEventArgs e)
    {
        FileUpload fuGameImage = (FileUpload)dvGame.FindControl("fuGameImage");
        string sVirtualFolder = "~/GamePics/";
        string sPhysicalFolder = Server.MapPath(sVirtualFolder);
        string sFileName = Guid.NewGuid().ToString();
        string sExtension = System.IO.Path.GetExtension(fuGameImage.FileName);

        fuGameImage.SaveAs(System.IO.Path.Combine(sPhysicalFolder, sFileName + sExtension));
        e.Values["GamePictureURL"] = sVirtualFolder + sFileName + sExtension;
    }
    protected void dvGame_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {
        FileUpload fuGameImage = (FileUpload)dvGame.FindControl("fuGameImage");
        string sVirtualFolder = "~/GamePics/";
        string sPhysicalFolder = Server.MapPath(sVirtualFolder);
        string sFileName = Guid.NewGuid().ToString();
        string sExtension = System.IO.Path.GetExtension(fuGameImage.FileName);

        fuGameImage.SaveAs(System.IO.Path.Combine(sPhysicalFolder, sFileName + sExtension));
        e.NewValues["GamePictureURL"] = sVirtualFolder + sFileName + sExtension;
    }
}