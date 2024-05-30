import Nav from "react-bootstrap/Nav";
import "bootstrap/dist/css/bootstrap.min.css"; //react bootstrap ekle

function CustomNavbar() {
  return (
    <Nav
      activeKey="/home"
      onSelect={(selectedKey) => alert(`selected ${selectedKey}`)}
    >
      <Nav.Item>
        <Nav.Link eventKey="disabled" disabled>
          NutriHub ADMIN
        </Nav.Link>
      </Nav.Item>
      <Nav.Item>
        <Nav.Link href="/urunler">Ürünler</Nav.Link>
      </Nav.Item>
      <Nav.Item>
        <Nav.Link href="/kullanicilar">Kullanıcılar</Nav.Link>
      </Nav.Item>
      <Nav.Item>
        <Nav.Link href="/blog">Blog</Nav.Link>
      </Nav.Item>
      <Nav.Item>
        <Nav.Link href="/kategoriler">Kategoriler</Nav.Link>
      </Nav.Item>
      <Nav.Item>
        <Nav.Link href="/siparisler">Siparişler</Nav.Link>
      </Nav.Item>
    </Nav>
  );
}

export default CustomNavbar;
