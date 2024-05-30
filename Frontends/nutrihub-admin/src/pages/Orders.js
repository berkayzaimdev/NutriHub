import Table from "react-bootstrap/Table";
import "bootstrap/dist/css/bootstrap.min.css";
import { Button, Modal } from "react-bootstrap";
import { useState } from "react";
function Orders() {
  const [show, setShow] = useState(false);

  const handleClose = () => setShow(false);
  const handleShow = () => setShow(true);

  const [loop, setLoop] = useState([1, 2, 3, 4, 5, 6, 7]);
  return (
    <div style={{ padding: "1rem 8rem" }}>
      <Table striped bordered hover>
        <thead>
          <tr>
            <th>ID</th>
            <th>Alıcı</th>
            <th>Adres</th>
            <th>E-posta</th>
            <th>Adres</th>
            <th>#</th>
          </tr>
        </thead>
        <tbody>
          {loop.map(() => (
            <tr>
              <td>1</td>
              <td>Mark</td>
              <td>Otto</td>
              <td>mark@mdo.com</td>
              <td>Şişli/İstanbul</td>
              <td>
                <Button variant="primary" onClick={handleShow}>
                  Ayrıntı
                </Button>

                <Modal show={show} onHide={handleClose}>
                  <Modal.Header closeButton>
                    <Modal.Title>Sipariş 1</Modal.Title>
                  </Modal.Header>
                  <Modal.Body>Adres Bilgisi</Modal.Body>
                  <Modal.Footer>
                    <Button variant="secondary" onClick={handleClose}>
                      Close
                    </Button>
                    <Button variant="danger" onClick={handleClose}>
                      Save Changes
                    </Button>
                  </Modal.Footer>
                </Modal>
              </td>
            </tr>
          ))}
        </tbody>
      </Table>
    </div>
  );
}

export default Orders;
