import React, { useState } from "react";
import { Dropdown, Modal, Button, Form } from "react-bootstrap";

function Categories() {
  const [show, setShow] = useState(false);

  const handleClose = () => setShow(false);
  const handleShow = () => setShow(true);
  const [loop, setLoop] = useState([1, 2, 3, 4, 5, 6, 7]);
  const [subCategoryCount, setSubCategoryCount] = useState(1);
  const subCategories = Array.from(
    { length: subCategoryCount },
    (_, index) => index + 1
  );

  return (
    <div style={{ padding: "1rem 6rem", textAlign: "center" }}>
      <Button
        variant="primary"
        onClick={handleShow}
        style={{ marginBottom: "1rem" }}
      >
        Kategori Ekle
      </Button>

      <Modal show={show} onHide={handleClose}>
        <Modal.Header closeButton>
          <Modal.Title>Modal heading</Modal.Title>
        </Modal.Header>
        <Modal.Body>
          <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
            <Form.Label>Kategori Adı</Form.Label>
            <Form.Control type="text" placeholder="" />
          </Form.Group>
          <Button onClick={() => setSubCategoryCount(subCategoryCount + 1)}>
            Alt Kategori Ekle: {subCategoryCount}
          </Button>
          {subCategories.map(() => (
            <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
              <Form.Label>Alt Kategori Adı</Form.Label>
              <Form.Control type="text" placeholder="" />
            </Form.Group>
          ))}
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
      {loop.map(() => (
        <Dropdown style={{ marginBottom: "1rem" }}>
          <Dropdown.Toggle variant="success" id="dropdown-basic">
            Kategori
          </Dropdown.Toggle>

          <Dropdown.Menu>
            <Dropdown.Item href="#/action-1">Alt Kategori 1</Dropdown.Item>
            <Dropdown.Item href="#/action-2">Alt Kategori 1</Dropdown.Item>
            <Dropdown.Item href="#/action-3">Alt Kategori 1</Dropdown.Item>
          </Dropdown.Menu>
        </Dropdown>
      ))}
    </div>
  );
}

export default Categories;
