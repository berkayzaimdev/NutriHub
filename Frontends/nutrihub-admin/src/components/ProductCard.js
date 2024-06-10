import React, { useState } from "react";
import image1 from "../images/image1.png";
import image2 from "../images/image2.png";
import { Button, Form, Modal } from "react-bootstrap";
import "bootstrap/dist/css/bootstrap.min.css";

function ProductCard() {
  const [show, setShow] = useState(false);

  const handleClose = () => setShow(false);
  const handleShow = () => setShow(true);
  return (
    <div
      className="home-product-card"
      style={{ padding: "10px", border: ".1rem solid black" }}
    >
      <div>
        <div>
          {" "}
          <Button
            variant="primary"
            onClick={handleShow}
            style={{ border: "none", width: "100%" }}
          >
            Düzenle
          </Button>
          <Modal show={show} onHide={handleClose}>
            <Modal.Header closeButton>
              <Modal.Title>Ürün ekle</Modal.Title>
            </Modal.Header>
            <Modal.Body>
              <Form.Group controlId="formFileMultiple" className="mb-3">
                <Form.Label>Ürün Fotoğrafları</Form.Label>
                <Form.Control type="file" multiple />
              </Form.Group>
              <Form.Group
                className="mb-3"
                controlId="exampleForm.ControlInput1"
              >
                <Form.Label>Ürün Adı</Form.Label>
                <Form.Control type="text" placeholder="" />
              </Form.Group>
              <div
                style={{
                  display: "flex",
                  columnGap: "1rem",
                  marginBottom: "1rem",
                }}
              >
                <Form.Select aria-label="Default select example">
                  <option>Kategori</option>
                  <option value="1">One</option>
                  <option value="2">Two</option>
                  <option value="3">Three</option>
                </Form.Select>
                <Form.Select aria-label="Default select example">
                  <option>Alt Kategori</option>
                  <option value="1">One</option>
                  <option value="2">Two</option>
                  <option value="3">Three</option>
                </Form.Select>
              </div>
              <Form.Group
                className="mb-3"
                controlId="exampleForm.ControlTextarea1"
              >
                <Form.Label>Ürün Açıklaması</Form.Label>
                <Form.Control as="textarea" rows={3} />
              </Form.Group>
              <Form.Group
                className="mb-3"
                controlId="exampleForm.ControlInput1"
              >
                <Form.Label>Ürün Stoğu</Form.Label>
                <Form.Control type="text" placeholder="" />
              </Form.Group>
            </Modal.Body>
            <Modal.Footer>
              <Button variant="secondary" onClick={handleClose}>
                Close
              </Button>
              <Button variant="primary" onClick={handleClose}>
                Save Changes
              </Button>
            </Modal.Footer>
          </Modal>
        </div>
        <div>
          <div
            className="modal show"
            style={{ display: "block", position: "initial" }}
          >
            <Button
              variant="danger"
              style={{ margin: "1rem 0", width: "100%" }}
            >
              Sil
            </Button>{" "}
          </div>
        </div>
      </div>
      <div style={{ display: "flex", justifyContent: "center" }}>
        <img
          src={image2}
          style={{ width: "175px", cursor: "pointer" }}
          onClick={() => {
            window.location.href = "/urun"; // URL stringini doğru şekilde atama
          }}
        ></img>
        <i
          className="ri-add-circle-line"
          style={{
            position: "relative",
            fontSize: "20px",
            cursor: "pointer",
          }}
        ></i>
      </div>

      <div
        style={{ marginTop: "1.5rem", borderTop: "1px solid black" }}
        onClick={() => {
          window.location.href = "/urun"; // URL stringini doğru şekilde atama
        }}
      ></div>
      <p
        style={{
          marginTop: "1rem",
          textAlign: "left",
          marginBottom: "1rem",
          cursor: "pointer",
          fontSize: "15px",
        }}
      >
        Progainer Çikolata 5000 Gr
      </p>
      <div
        style={{
          display: "flex",
          justifyContent: "space-between",
        }}
      >
        <p style={{ cursor: "pointer", fontSize: "14px" }}>
          <strong>599,00 TL</strong>
        </p>
        <p style={{ color: "orange", fontSize: "12px" }}>
          <i className="ri-star-fill"></i>
          <i className="ri-star-fill"></i>
          <i className="ri-star-fill"></i>
          <i className="ri-star-fill"></i>
          <i className="ri-star-fill"></i>
        </p>
      </div>
    </div>
  );
}

export default ProductCard;
