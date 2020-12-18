using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.AppBase
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPrincipal : MasterDetailPage
	{
		public MenuPrincipal()
		{
			InitializeComponent();
		}

		private void AbrirContentPage(object sender, EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Paginas.PaginasConteudo.Conteudo01());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

		private void AbrirNavigationPage(object sender, EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Paginas.Navegacao.Conteudo1());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

		private void AbrirCarouselPage(object sender, EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Paginas.Carousel.Carousel());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

		private void AbrirTabbedPage(object sender, EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Paginas.Tabbed.Abas());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

		private void AbrirMasterDetailPage(object sender, EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.MenuLateral.MenuLateral();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

		private void AbrirModal(object sender, EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Paginas.Modal.PaginaModal());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

		private void AbrirStackLayout(object sender, EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Estilos.EstiloPilha.Pilha();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

		private void AbrirGridLayout(object sender, EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Estilos.EstiloGrid.PgGrid();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbsoluteLayout(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Estilos.EstiloAbsoluto.Absoluto();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}
		private void RelavitoLayout(object sender, EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Estilos.EstiloRelativo.Relativo();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void FlexLayout(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Estilos.EstiloFlex.EstiloFlexPG();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirScroll(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Estilos.EstiloScroll.Scroll();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirContentView(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Estilos.EstiloContent.ControlePagina();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirFrame(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Estilos.EstiloFrame.Quadrado();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirBoxViewControle(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.CaixaControle();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirLabelControle(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.LabelControle();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirBotaoControle(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.BotaoControle();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirBotaoImgControle(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.BotaoImagemControle());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirImagemControle(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.ImagemControle());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirEntryControle(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.CampoEntradaSimples());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirEditorControle(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.CampoEditorControle());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirPickerControle(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.PickerControle());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirActivityIndicatorControle(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.IndicadorAtividadeControle());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirBarraPesquisaControle(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.BarraPesquisa());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirRefreshViewControle(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.RefreshControle());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirSwipeViewControle(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.SwipeControle());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirWebViewControle(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.WebViewControle());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirExpanderControle(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.ExpanderControle());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirTableView(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.TableViewLista());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirListView(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.ListViewLista());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirCollectionView(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.CollecionViewLista());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

        private void AbrirCArouselView(object sender, EventArgs e)
        {
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.CarouselView());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}
    }
}