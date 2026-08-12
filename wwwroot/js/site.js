document.addEventListener('DOMContentLoaded', () => {
  const routes = {
    Sales: { dashboard:'Index', customers:'Customers', 'customer-detail':'CustomerDetails', 'customer-create':'CreateCustomer', contracts:'Contracts', 'contract-detail':'ContractDetails', 'contract-create':'CreateContract', orders:'PurchaseOrders', 'order-detail':'PurchaseOrderDetails', 'order-create':'CreatePurchaseOrder' },
    Customer: { dashboard:'Index', contracts:'Contracts', 'contract-detail':'ContractDetails', orders:'Orders', 'order-detail':'OrderDetails', fleet:'Fleet', 'fleet-edit':'FleetDetails', invoices:'Invoices', 'invoice-detail':'InvoiceDetails' },
    Finance: { dashboard:'Index', queue:'OrdersQueue', 'order-detail':'OrderDetails', 'active-orders':'ActiveOrders', reconciliation:'Reconciliation', invoices:'Invoices', 'invoice-detail':'InvoiceDetails', payments:'Payments' },
    Logistics: { dashboard:'Index', 'available-orders':'AvailableOrders', 'order-detail':'OrderDetails', 'collection-type':'CollectionType', 'truck-select':'SelectTruck', 'gate-check':'GateCheck', 'weigh-in':'WeighIn', 'weigh-out':'WeighOut', summary:'TransactionSummary', fleet:'Fleet', log:'WeighbridgeLog' },
    Management: { dashboard:'Index', customers:'Customers', contracts:'Contracts', orders:'Orders', weighbridge:'Weighbridge', invoices:'Invoices', fleet:'Fleet', users:'Users', audit:'Audit', reports:'Reports' },
    SiteManager: { dashboard:'Index', tracking:'Tracking', 'tracking-detail':'TrackingDetails', weighbridge:'Weighbridge', fleet:'Fleet', audit:'Audit' }
  };
  document.querySelector('[data-login-form]')?.addEventListener('submit', event => {
    event.preventDefault();
    const route = event.currentTarget.querySelector('input[name="role"]:checked')?.value;
    if (route) window.location.href = route;
  });
  document.querySelectorAll('.role-option').forEach(option => option.addEventListener('click', () => {
    document.querySelectorAll('.role-option').forEach(item => item.classList.remove('selected'));
    option.classList.add('selected');
  }));
  document.querySelectorAll('[data-portal]').forEach(portal => {
    const screens = [...portal.querySelectorAll('[data-screen]')];
    const title = portal.querySelector('[data-page-title]');
    const controller = portal.dataset.controller;
    const labels = { dashboard:'Dashboard', customers:'Customers', 'customer-detail':'Customer Details', 'customer-create':'Add Customer', contracts:'Contracts', 'contract-detail':'Contract Details', 'contract-create':'Create Contract', orders:'Purchase Orders', 'order-detail':'Purchase Order Details', 'order-create':'Create Purchase Order', queue:'Orders Queue', 'active-orders':'Active Orders', reconciliation:'Reconciliation', weighbridge:'Weighbridge Activity', tracking:'Order Tracking', 'tracking-detail':'Order Details', fleet:'Fleet Compliance', 'fleet-edit':'Fleet Details', invoices:'Invoices', 'invoice-detail':'Invoice Details', payments:'Payments', users:'User Management', audit:'Audit Log', reports:'Reports' };
    function navigate(name) {
      const target = portal.querySelector(`[data-screen="${name}"]`);
      if (!target) {
        const action = routes[controller]?.[name];
        if (action) window.location.href = `/${controller}/${action}`;
        return;
      }
      screens.forEach(screen => screen.classList.toggle('active', screen === target));
      portal.querySelectorAll('.side-link').forEach(link => link.classList.toggle('active', link.dataset.nav === name));
      if (title) title.textContent = labels[name] || 'Wescoal Portal';
      portal.classList.remove('menu-open');
      window.scrollTo({ top: 0, behavior: 'smooth' });
      history.replaceState(null, '', `#${name}`);
    }
    portal.querySelectorAll('[data-nav]').forEach(link => link.addEventListener('click', event => {
      event.preventDefault();
      navigate(link.dataset.nav);
    }));
    portal.querySelector('[data-menu]')?.addEventListener('click', () => portal.classList.toggle('menu-open'));
    const initial = location.hash.slice(1);
    if (initial && portal.querySelector(`[data-screen="${initial}"]`)) navigate(initial);
  });
  const toast = document.querySelector('[data-toast-box]');
  let timer;
  function showToast(message) {
    if (!toast) return;
    toast.textContent = message;
    toast.classList.add('show');
    clearTimeout(timer);
    timer = setTimeout(() => toast.classList.remove('show'), 2800);
  }
  document.querySelectorAll('[data-toast]').forEach(button => button.addEventListener('click', () => showToast(button.dataset.toast)));
  document.querySelectorAll('[data-demo-form]').forEach(form => form.addEventListener('submit', event => {
    event.preventDefault();
    if (!form.reportValidity()) return;
    showToast(form.dataset.success || 'Saved successfully');
    const next = form.dataset.next;
    if (next) {
      setTimeout(() => {
        const portal = form.closest('[data-portal]');
        const target = portal?.querySelector(`[data-screen="${next}"]`);
        if (!portal || !target) {
          const controller = portal?.dataset.controller;
          const action = routes[controller]?.[next];
          if (controller && action) window.location.href = `/${controller}/${action}`;
          return;
        }
        portal.querySelectorAll('[data-screen]').forEach(screen => screen.classList.toggle('active', screen === target));
        portal.querySelectorAll('.side-link').forEach(link => link.classList.toggle('active', link.dataset.nav === next));
        window.scrollTo({ top: 0, behavior: 'smooth' });
        history.replaceState(null, '', `#${next}`);
      }, 450);
    }
  }));
});
