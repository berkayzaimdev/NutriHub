import React from "react";
import Nav from "react-bootstrap/Nav";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import "bootstrap/dist/css/bootstrap.min.css";
import "./Sidebar.css";
import {
  faUsers,
  faBox,
  faList,
  faScroll,
} from "@fortawesome/free-solid-svg-icons";
import { faHome } from "@fortawesome/free-solid-svg-icons/faHome";
import { faShop } from "@fortawesome/free-solid-svg-icons/faShop";
import { faTicket } from "@fortawesome/free-solid-svg-icons/faTicket";

function Sidebar() {
  return (
    <div className="sidebar">
      <Nav activeKey="/home" className="flex-column">
        <Nav.Item>
          <Nav.Link href="/" className="sidebar-title">
            NutriHub ADMIN
          </Nav.Link>
        </Nav.Item>
        <Nav.Item>
          <Nav.Link href="/">
            <FontAwesomeIcon icon={faHome} style={{ marginRight: "0.5rem" }} />
            Dashboard
          </Nav.Link>
        </Nav.Item>
        <Nav.Item>
          <Nav.Link href="/urunler">
            <FontAwesomeIcon icon={faBox} style={{ marginRight: "0.5rem" }} />
            Ürünler
          </Nav.Link>
        </Nav.Item>
        <Nav.Item>
          <Nav.Link href="/kategoriler">
            <FontAwesomeIcon icon={faList} style={{ marginRight: "0.5rem" }} />
            Kategoriler
          </Nav.Link>
        </Nav.Item>
        <Nav.Item>
          <Nav.Link href="/markalar">
            <FontAwesomeIcon icon={faShop} style={{ marginRight: "0.5rem" }} />
            Markalar
          </Nav.Link>
        </Nav.Item>
        <Nav.Item>
          <Nav.Link href="/kuponlar">
            <FontAwesomeIcon
              icon={faTicket}
              style={{ marginRight: "0.5rem" }}
            />
            Kuponlar
          </Nav.Link>
        </Nav.Item>
        <Nav.Item>
          <Nav.Link href="/kullanicilar">
            <FontAwesomeIcon icon={faUsers} style={{ marginRight: "0.5rem" }} />
            Kullanıcılar
          </Nav.Link>
        </Nav.Item>
        <Nav.Item>
          <Nav.Link href="/siparisler">
            <FontAwesomeIcon
              icon={faScroll}
              style={{ marginRight: "0.5rem" }}
            />
            Siparişler
          </Nav.Link>
        </Nav.Item>
      </Nav>
    </div>
  );
}

export default Sidebar;
